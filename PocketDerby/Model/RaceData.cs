using System;
using System.Collections.Generic;

namespace PocketDerby.Model {
    /// <summary>
    /// レースデータクラス
    /// </summary>
    internal class RaceData {

        /// <summary>
        /// スタート位置
        /// </summary>
        private const double C_StartPosition = 86.0;

        /// <summary>
        /// 出走馬一覧
        /// </summary>
        public List<Horse> Horses { get; }
        /// <summary>
        /// 選択した馬
        /// </summary>
        public Horse SelectedHorse { get; }
        /// <summary>
        /// 掛け金
        /// </summary>
        public int BetAmount { get; }
        /// <summary>
        /// 馬の現在位置（キー: 馬番,値: 位置）
        /// </summary>
        public Dictionary<int, double> HorsePositions { get; }
        /// <summary>
        /// レース結果（着順）
        /// </summary>
        public List<Horse> RaceResults { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vHorses">出走馬一覧</param>
        /// <param name="vSelectedHorse">選択した馬</param>
        /// <param name="vBetAmount">掛け金</param>
        public RaceData(List<Horse> vHorses, Horse vSelectedHorse, int vBetAmount) {
            if (vHorses == null || vHorses.Count == 0) {
                throw new ArgumentException("出走馬が指定されていません。", nameof(vHorses));
            }
            if (vSelectedHorse == null) {
                throw new ArgumentNullException(nameof(vSelectedHorse), "選択した馬が指定されていません。");
            }
            if (!vHorses.Contains(vSelectedHorse)) {
                throw new ArgumentException("選択した馬が出走馬に含まれていません。", nameof(vSelectedHorse));
            }
            if (vBetAmount < 0) {
                throw new ArgumentOutOfRangeException(nameof(vBetAmount), vBetAmount, "掛け金は0以上である必要があります。");
            }
            this.Horses = vHorses;
            this.SelectedHorse = vSelectedHorse;
            this.BetAmount = vBetAmount;
            this.HorsePositions = new Dictionary<int, double>();
            foreach (var wHorse in vHorses) {
                this.HorsePositions[wHorse.Number] = C_StartPosition;
            }
            this.RaceResults = null;
        }
    }
}