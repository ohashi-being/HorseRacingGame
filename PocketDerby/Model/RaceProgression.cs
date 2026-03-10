using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketDerby.Model {
    /// <summary>
    /// レース進行を管理するクラス
    /// </summary>
    internal class RaceProgression {

        /// <summary>
        /// ゴール位置
        /// </summary>
        private const double C_GoalPosition = 600.0;
        /// <summary>
        /// 位置更新の係数
        /// </summary>
        private const double C_PositionCoefficient = 0.04;

        /// <summary>
        /// 進行管理の対象となるレースデータ
        /// </summary>
        private RaceData FRaceData;
        /// <summary>
        ///  ゴールした馬の着順（キー: 馬番, 値: 着順）
        /// </summary>
        private Dictionary<int, int> FFinishOrder;
        /// <summary>
        /// 現在の着順
        /// </summary>
        private int FCurrentRank;
        /// <summary>
        /// レースが進行中かどうか
        /// </summary>
        public bool IsRaceRunning { get; private set; }
        /// <summary>
        /// レースが終了したかどうか
        /// </summary>
        private bool FIsRaceFinished;

        /// <summary>
        /// 指定されたレースデータを使用してRaceProgressionクラスの新しいインスタンスを初期化する
        /// </summary>
        /// <param name="vRaceData">対象となるレースデータ</param>
        public RaceProgression(RaceData vRaceData) {
            if (vRaceData == null) {
                throw new ArgumentNullException(nameof(vRaceData), "レースデータが指定されていません。");
            }

            this.FRaceData = vRaceData;
            this.FFinishOrder = new Dictionary<int, int>();
            this.FCurrentRank = 1;
            this.IsRaceRunning = false;
        }

        /// <summary>
        /// レースを開始状態にする
        /// </summary>
        public void StartRace() {
            if (this.FIsRaceFinished) {
                throw new InvalidOperationException("レースは既に終了しています。新しいRaceProgressionを生成してください。");
            }
            if (this.IsRaceRunning) {
                throw new InvalidOperationException("レースは既に開始されています。");
            }
            this.IsRaceRunning = true;
        }

        /// <summary>
        /// レースの1フレームの処理を実行する
        /// </summary>
        public void UpdateRaceFrame() {

            if (!this.IsRaceRunning) return;

            foreach (var wHorse in this.FRaceData.Horses) {
                if (this.FFinishOrder.ContainsKey(wHorse.Number)) continue;
                MoveHorse(wHorse);
                CheckGoals(wHorse);
            }
            CheckRaceEnd();
        }

        /// <summary>
        /// 指定された馬の位置を更新する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        private void MoveHorse(Horse vHorse) {

            double wCurrentPosition = this.FRaceData.HorsePositions[vHorse.Number];

            // TODO: 現時点では、トラップでの補正はない
            double wNewPosition = wCurrentPosition + (vHorse.Speed * C_PositionCoefficient);

            this.FRaceData.HorsePositions[vHorse.Number] = Math.Min(wNewPosition, C_GoalPosition);
        }

        /// <summary>
        /// 指定された馬がゴールしたか判定し、着順を記録する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        private void CheckGoals(Horse vHorse) {
            if (this.FRaceData.HorsePositions[vHorse.Number] >= C_GoalPosition) {
                this.FFinishOrder[vHorse.Number] = this.FCurrentRank;
                this.FCurrentRank++;
            }
        }

        /// <summary>
        /// すべての馬がゴールしていればレースを終了する
        /// </summary>
        private void CheckRaceEnd() {
            if (this.FFinishOrder.Count != this.FRaceData.Horses.Count) {
                return;
            }
            this.IsRaceRunning = false;
            this.FIsRaceFinished = true;

            var wRankedHorses = this.FRaceData.Horses
                .OrderBy(x => this.FFinishOrder[x.Number])
                .ToList();

            this.FRaceData.SetRaceResults(wRankedHorses);
        }
    }
}
