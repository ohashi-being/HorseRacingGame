using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketDerby.Model {
    /// <summary>
    /// レースデータクラス
    /// </summary>
    internal class RaceData {

        /// <summary>
        /// 出走馬一覧
        /// </summary>
        public IReadOnlyList<Horse> Horses { get; }
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
        public IReadOnlyList<Horse> RaceResults { get; private set; }

        /// <summary>
        /// レース結果を設定する
        /// </summary>
        /// <param name="vRaceResults">着順に並んだ馬のリスト</param>
        public void SetRaceResults(List<Horse> vRaceResults) {
            if (vRaceResults == null || vRaceResults.Count == 0) {
                throw new ArgumentException("無効なレース結果です。");
            }
            this.RaceResults = vRaceResults.AsReadOnly();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vHorses">出走馬一覧</param>
        /// <param name="vSelectedHorse">選択した馬</param>
        /// <param name="vBetAmount">掛け金</param>
        public RaceData(List<Horse> vHorses, Horse vSelectedHorse, int vBetAmount) {

            ValidateArguments(vHorses, vSelectedHorse, vBetAmount);

            this.Horses = new List<Horse>(vHorses).AsReadOnly();
            this.SelectedHorse = vSelectedHorse;
            this.BetAmount = vBetAmount;
            this.HorsePositions = vHorses.ToDictionary(x => x.Number, horse => RaceRegulation.C_StartPosition);
        }


        /// <summary>
        /// コンストラクタ引数の妥当性を検証する
        /// </summary>
        private void ValidateArguments(List<Horse> vHorses, Horse vSelectedHorse, int vBetAmount) {
            if (vHorses == null || vHorses.Count == 0) {
                throw new ArgumentException("出走馬が指定されていません。", nameof(vHorses));
            }
            if (vSelectedHorse == null) {
                throw new ArgumentNullException(nameof(vSelectedHorse), "選択した馬が指定されていません。");
            }
            if (!vHorses.Contains(vSelectedHorse)) {
                throw new ArgumentException("選択した馬が出走馬に含まれていません。", nameof(vSelectedHorse));
            }
            if (vBetAmount < 100) {
                throw new ArgumentOutOfRangeException(nameof(vBetAmount), vBetAmount, "掛け金は100円以上である必要があります。");
            }
        }
    }
}