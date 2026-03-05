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
            if (this.IsRaceRunning) {
                throw new InvalidOperationException("レースは既に開始されています。");
            }
            this.IsRaceRunning = true;
        }

        /// <summary>
        /// レース状態を1ステップ進める
        /// </summary>
        public void AdvancedRace() {

            if (!this.IsRaceRunning) return;

            foreach (var wHorse in this.FRaceData.Horses) {
                if (this.FFinishOrder.ContainsKey(wHorse.Number)) continue;
                UpdatePositions(wHorse);
                CheckGoals(wHorse);
            }

            if (this.FFinishOrder.Count == this.FRaceData.Horses.Count) EndRace();
        }

        /// <summary>
        /// 指定された馬の現在位置を更新する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        private void UpdatePositions(Horse vHorse) {

            double wCurrentPosition = this.FRaceData.HorsePositions[vHorse.Number];

            // 現時点では、トラップでの補正はない
            double wNewPosition = wCurrentPosition + ( vHorse.Speed * C_PositionCoefficient );

            if (wNewPosition > C_GoalPosition) {
                wNewPosition = C_GoalPosition;
            }

            this.FRaceData.HorsePositions[vHorse.Number] = wNewPosition;
        }

        /// <summary>
        /// 指定された馬のゴール判定を行い、ゴールしている馬がいれば着順を記録する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        private void CheckGoals(Horse vHorse) {
            if (this.FRaceData.HorsePositions[vHorse.Number] >= C_GoalPosition) {
                this.FFinishOrder[vHorse.Number] = this.FCurrentRank;
                this.FCurrentRank++;
            }
        }

        /// <summary>
        /// レースを終了様態にし、レース結果をRaceDataに設定する
        /// </summary>
        private void EndRace() {
            this.IsRaceRunning = false;

            var wRankedHorses = this.FRaceData.Horses
                .OrderBy(x => this.FFinishOrder[x.Number])
                .ToList();

            this.FRaceData.SetRaceResults(wRankedHorses);
        }
    }
}
