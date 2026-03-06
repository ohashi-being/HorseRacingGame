namespace PocketDerby.Model {
    /// <summary>
    /// トラップの実体を作成するクラス
    /// </summary>
    internal class TrapEntity {

        /// <summary>
        /// トラップのマスタデータ
        /// </summary>
        public Trap TrapData { get; }
        /// <summary>
        /// トラップの位置
        /// </summary>
        public double Position { get; }
        /// <summary>
        /// トラップが発生する馬の名前
        /// </summary>
        public string HorseName { get; }
        /// <summary>
        /// トラップが発生したかどうか
        /// </summary>
        public bool IsTriggered { get; private set; }

        /// <summary>
        /// スピード補正値
        /// </summary>
        public double SpeedCorrection => this.TrapData.SpeedCorrection;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vTrapData">トラップのマスタデータ</param>
        /// <param name="vPosition">トラップ位置</param>
        /// <param name="vHorseName">馬の名前</param>
        public TrapEntity(Trap vTrapData, double vPosition, string vHorseName) {
            this.TrapData = vTrapData;
            this.HorseName = vHorseName;
            this.Position = vPosition;
            this.IsTriggered = false;
        }

        /// <summary>
        /// トラップを発生済みに設定する
        /// </summary>
        public void SetTriggered() {
            this.IsTriggered = true;
        }
    }
}
