using System;
using System.Collections.Generic;

namespace アプリ画面作成.Model {
    internal class GameState {
        #region 定数
        /// <summary>
        /// 初期所持金
        /// </summary>
        public const int C_InitialMoney = 10000;
        /// <summary>
        /// クリア条件（所持金がこの金額以上になったらクリア）
        /// </summary>
        public const int C_ClearThreshold = 50000;
        /// <summary>
        /// 破産条件（所持金がこの金額以下になったら破産）
        /// </summary>
        public const int C_BankruptThreshold = 100;
        /// <summary>
        /// 最低賭け金
        /// </summary>
        public const int C_MinBet = 100;
        /// <summary>
        /// 賭け金の単位
        /// </summary>
        public const int C_BetUnit = 100;
        /// <summary>
        /// コース距離
        /// </summary>
        public const double C_CourseDistance = 600.0;
        /// <summary>
        /// 出走頭数
        /// </summary>
        public const int C_HorseCount = 5;
        /// <summary>
        /// オッズ係数
        /// </summary>
        private const double C_OddsCoefficient = 2.1;
        #endregion

        // ゲームの状態
        /// <summary>
        /// 現在の所持金
        /// </summary>
        public int Money { get; private set; }
        /// <summary>
        /// 出走馬一覧
        /// </summary>
        public List<Horse> Horses { get; private set; }
        /// <summary>
        /// 選択した馬
        /// </summary>
        public Horse SelectedHorse { get; private set; }
        /// <summary>
        /// 掛け金
        /// </summary>
        public int BetAmount { get; private set; }
        /// <summary>
        /// レース結果（着順）
        /// </summary>
        public List<Horse> RaceResults { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GameState() {
            this.Money = C_InitialMoney;
            Reset();
        }

        // ※メソッド分割する
        /// <summary>
        /// 新たなレースを開始するための初期化処理
        /// </summary>
        public void CreateNewRace() {
            var wHorseName = Horse.GetRandomNames(C_HorseCount);
            this.Horses = new List<Horse>();
            for (int i = 0 ; i < C_HorseCount ; i++) {
                var wHorse = Horse.Create(i + 1, wHorseName[i]);
                this.Horses.Add(wHorse);
            }
            CalculateOdds();
            this.SelectedHorse = null;
            this.BetAmount = 0;
            this.RaceResults = new List<Horse>();
        }

        /// <summary>
        /// 全馬のオッズを算出する
        /// オッズ = (全馬の平均有実効スピード / 各馬の実効スピード) * オッズ係数(2.1)
        /// </summary>
        private void CalculateOdds() {
            double wAverageEffective = 0;
            foreach (var wHorse in this.Horses) {
                wAverageEffective += wHorse.EffectiveSpeed;
            }
            wAverageEffective /= this.Horses.Count;

            foreach (var wHorse in this.Horses) {
                double wRawOdds = ( wAverageEffective / wHorse.EffectiveSpeed ) * C_OddsCoefficient;
                wRawOdds = Math.Floor(wRawOdds * 10) / 10.0;
                if (wRawOdds < 1.1) {
                    wRawOdds = 1.1;
                }
                wHorse.Odds = wRawOdds;
            }
        }

        /// <summary>
        /// 賭け金を判定する
        /// </summary>
        /// <param name="vBetAmount"></param>
        /// <returns></returns>
        public bool TrySetBet(int vBetAmount) {
            if (vBetAmount < C_MinBet) return false;
            if (vBetAmount > this.Money) return false;
            if (vBetAmount % C_BetUnit != 0) return false;
            this.BetAmount = vBetAmount;
            return true;
        }

        /// <summary>
        /// 馬を選択する
        /// </summary>
        public bool TrySelectHorse(Horse vHorse) {
            if (vHorse == null) return false;
            if (!this.Horses.Contains(vHorse)) return false;
            this.SelectedHorse = vHorse;
            return true;
        }

        /// <summary>
        /// レース結果を設定する
        /// </summary>
        public void SetRaceResults(List<Horse> vResults) {
            this.RaceResults = vResults;
        }

        // 結果処理
        /// <summary>
        /// 選択した馬が1着かどうか
        /// </summary>
        /// <returns></returns>
        public bool IsWin() => this.SelectedHorse != null && this.SelectedHorse.Rank == 1;
        /// <summary>
        /// 払戻金を算出する
        /// </summary>
        /// <returns></returns>
        public int CalculatePayout() {
            if (!IsWin()) return 0;
            return (int)( this.BetAmount * this.SelectedHorse.Odds );
        }
        /// <summary>
        /// 勝敗に応じて所持金を増減させる
        /// </summary>
        public void ApplyResult() {
            this.Money -= this.BetAmount;
            this.Money += CalculatePayout();
        }

        // ゲーム終了判定
        /// <summary>
        /// クリア条件を満たしているかどうか
        /// </summary>
        /// <returns></returns>
        public bool IsGameCleared() {
            return this.Money >= C_ClearThreshold;
        }
        /// <summary>
        /// 破産条件を満たしているかどうか
        /// </summary>
        /// <returns></returns>
        public bool IsBankrupt() {
            return this.Money < C_BankruptThreshold;
        }

        /// <summary>
        /// ゲームをリセットして初期状態に戻す
        /// </summary>
        public void Reset() {
            this.Horses = null;
            this.SelectedHorse = null;
            this.BetAmount = 0;
            this.RaceResults = null;
        }
        /// <summary>
        /// ゲームを完全にリセットして初期状態に戻す（所持金も初期化）
        /// </summary>
        public void FullReset() {
            this.Money = C_InitialMoney;
            Reset();
        }
    }
}
