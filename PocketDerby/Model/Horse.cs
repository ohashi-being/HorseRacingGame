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
        public string Name { get; }
        /// <summary>
        /// 運の良さ
        /// </summary>
        public int Luck { get; }
        /// <summary>
        /// スピード
        /// </summary>
        public int Speed { get; }
        /// <summary>
        /// オッズ
        /// </summary>
        public double Odds { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vNumber">馬番</param>
        /// <param name="vName">馬名</param>
        /// <param name="vLuck">運の良さ</param>
        /// <param name="vSpeed">スピード</param>
        /// <param name="vOdds">オッズ</param>
        public Horse(int vNumber, string vName, int vLuck, int vSpeed, double vOdds) {
            this.Number = vNumber;
            this.Name = vName;
            this.Luck = vLuck;
            this.Speed = vSpeed;
            this.Odds = vOdds;
        }

    }
}
