namespace PocketDerby.Model {
    /// <summary>
    /// 馬のクラス
    /// </summary>
    internal class Horse {
        /// <summary>
        /// 馬番
        /// </summary>
        public int Number { get; }
        /// <summary>
        /// 馬名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 運の良さ
        /// </summary>
        public int Luck { get; set; }
        /// <summary>
        /// スピード
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// オッズ
        /// </summary>
        public double Odds { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vNumber">馬番</param>
        public Horse(int vNumber) {
            this.Number = vNumber;
        }

    }
}
