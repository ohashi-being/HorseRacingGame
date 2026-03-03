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

            this.FFinishOrder.Clear();
            this.FCurrentRank = 1;
            this.IsRaceRunning = true;
            foreach (var wHorseNumber in this.FRaceData.HorsePositions.Keys.ToList()) {
                this.FRaceData.HorsePositions[wHorseNumber] = 0.0;
            }
        }

        /// <summary>
        /// レース状態を1ステップ進める
        /// </summary>
        /// <returns>全馬がゴールしていればtrue、そうでなければfalse/returns>
        public bool UpdateRaceState() {
            if (!this.IsRaceRunning) {
                return true;
            }

            UpdatePositions();
            CheckGoals();

            if (this.FFinishOrder.Count == this.FRaceData.Horses.Count) {
                EndRace();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 各馬の現在位置を更新する
        /// </summary>
        private void UpdatePositions() {
            foreach (var wHorse in this.FRaceData.Horses) {
                if (this.FFinishOrder.ContainsKey(wHorse.Number)) continue;

                double wCurrentPosition = this.FRaceData.HorsePositions[wHorse.Number];
                // 現時点では、トラップでの補正はない
                double wNewPosition = wCurrentPosition + ( wHorse.Speed * C_PositionCoefficient );

                if (wNewPosition > C_GoalPosition) {
                    wNewPosition = C_GoalPosition;
                }

                this.FRaceData.HorsePositions[wHorse.Number] = wNewPosition;
            }
        }

        /// <summary>
        /// 各馬の位置を確認し、ゴールしている馬がいれば着順を記録する
        /// </summary>
        private void CheckGoals() {
            foreach (var wHorse in this.FRaceData.Horses) {
                if (this.FFinishOrder.ContainsKey(wHorse.Number)) continue;

                if (this.FRaceData.HorsePositions[wHorse.Number] >= C_GoalPosition) {
                    this.FFinishOrder[wHorse.Number] = this.FCurrentRank;
                    this.FCurrentRank++;
                }
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
