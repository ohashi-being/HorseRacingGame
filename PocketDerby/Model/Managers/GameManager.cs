using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketDerby.Model {
    /// <summary>
    /// ゲーム全体を管理するクラス
    /// </summary>
    internal class GameManager {

        /// <summary>
        /// プレイヤーの所持金
        /// </summary>
        public PlayerMoney PlayerMoney { get; } = new PlayerMoney();

        /// <summary>
        /// 現在の出走馬一覧
        /// </summary>
        public IReadOnlyList<Horse> CurrentHorses { get; private set; }

        /// <summary>
        /// 現在のレースデータ
        /// </summary>
        private RaceData CurrentRaceData { get; set; }

        /// <summary>
        /// 現在のレース進行管理
        /// </summary>
        private RaceProgression RaceProgression { get; set; }

        /// <summary>
        /// 現在のトラップ管理
        /// </summary>
        private TrapManager TrapManager { get; } = new TrapManager();


        // ① レース準備フェーズ
        /// <summary>
        /// 馬とトラップの生成を行う
        /// </summary>
        /// <param name="vHorseCount">出走馬の数</param>
        public void SetupNewRace(int vHorseCount) {

            var wHorses = HorseGenerator.GenerateHorses(vHorseCount);

            OddsCalculator.SetOdds(wHorses);

            this.TrapManager.CreateTraps(wHorses);

            this.CurrentHorses = wHorses.AsReadOnly();

            this.CurrentRaceData = null;
            this.RaceProgression = null;
        }

        // ② 馬券購入・レース開始フェーズ
        /// <summary>
        /// 馬券を購入する
        /// </summary>
        /// <param name="vHorse">賭ける馬</param>
        /// <param name="vBetAmount">賭け金</param>
        /// <param name="vErrorMessage">エラー時のメッセージ</param>
        /// <returns>購入成功ならtrue</returns>
        public bool TryBuyTicket(Horse vHorse, int vBetAmount, out string vErrorMessage) {

            if (this.CurrentHorses == null || this.CurrentHorses.Count == 0) {
                vErrorMessage = "レースの準備が完了していません。";
                return false;
            }

            if (this.RaceProgression != null) {
                vErrorMessage = "レースが既に開始されています。";
                return false;
            }

            if (!BetCalculator.ValidateBetAmount(vBetAmount, this.PlayerMoney.Money, out vErrorMessage)) {
                return false;
            }

            this.PlayerMoney.SubtractMoney(vBetAmount);

            this.CurrentRaceData = new RaceData(this.CurrentHorses.ToList(), vHorse, vBetAmount);

            return true;
        }

        /// <summary>
        /// レースを開始する
        /// </summary>
        public void StartRace() {

            if (this.CurrentRaceData == null) {
                throw new InvalidOperationException("レースデータが存在しません。馬券を購入してください。");
            }

            if (this.RaceProgression != null) {
                throw new InvalidOperationException("レースは既に開始されています。");
            }

            this.RaceProgression = new RaceProgression(this.CurrentRaceData);
            this.RaceProgression.StartRace();
        }

        // ③ レース進行フェーズ
        /// <summary>
        /// レース進行処理を呼び出す
        /// </summary>
        /// <param name="vMessages">このフレームで発生したトラップのメッセージ一覧</param>
        /// <returns>1フレーム進めた結果、レースが「終了」した場合はtrue</returns>
        public bool UpdateRace(out List<string> vMessages) {

            vMessages = new List<string>();

            if (this.RaceProgression == null) {
                throw new InvalidOperationException("レース進行管理が初期化されていません。レースを開始してください。");
            }

            if (!this.RaceProgression.IsRaceRunning) {
                throw new InvalidOperationException("レースは既に終了しています。ProcessRaceEnd を呼び出してください。");
            }

            this.RaceProgression.UpdateRaceFrame();

            foreach (var wHorse in this.CurrentHorses) {

                double wCurrentPos = this.CurrentRaceData.HorsePositions[wHorse.Number];

                if (wCurrentPos >= RaceRegulation.C_GoalPosition) {
                    continue;
                }

                TrapEntity wTrap = this.TrapManager.GetTrap(wHorse.Number, wCurrentPos);

                if (wTrap == null) continue;

                wTrap.SetTriggered();

                if (this.TrapManager.IsAvoided(wHorse.Luck)) {
                    vMessages.Add(wTrap.Type.GetAvoidMessage(wHorse.Name));
                } else {
                    vMessages.Add(wTrap.Type.GetTriggerMessage(wHorse.Name));
                    this.CurrentRaceData.HorseSpeedCorrection[wHorse.Number] *= wTrap.SpeedCorrection;
                }
            }

            return !this.RaceProgression.IsRaceRunning;
        }

        // ④ レース精算フェーズ
        /// <summary>
        /// レース終了時の精算を行う
        /// </summary>
        /// <returns>今回の払戻金</returns>
        public int ProcessRaceEnd() {

            if (this.RaceProgression == null) {
                throw new InvalidOperationException("レースが開始されていません。");
            }

            if (this.RaceProgression.IsRaceRunning) {
                throw new InvalidOperationException("レースがまだ進行中です。UpdateRace でレースを完了させてください。");
            }

            if (this.CurrentRaceData?.RaceResults == null || this.CurrentRaceData.RaceResults.Count == 0) return 0;

            var wFirstPlaceHorse = this.CurrentRaceData.RaceResults[0];
            int wPayout = 0;

            if (this.CurrentRaceData.SelectedHorse.Number == wFirstPlaceHorse.Number) {
                wPayout = BetCalculator.CalculatePayout(this.CurrentRaceData.BetAmount, this.CurrentRaceData.SelectedHorse.Odds);

                this.PlayerMoney.AddMoney(wPayout);
            }

            this.CurrentRaceData = null;
            this.RaceProgression = null;

            return wPayout;
        }
    }
}
