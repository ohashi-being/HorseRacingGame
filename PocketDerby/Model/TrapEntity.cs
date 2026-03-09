namespace PocketDerby.Model {
    /// <summary>
    /// トラップの実体を作成するクラス
    /// </summary>
    internal class TrapEntity {

        /// <summary>
        /// トラップの種類
        /// </summary>
        public Trap Type { get; }
        /// <summary>
        /// トラップの位置
        /// </summary>
        public double Position { get; }
        /// <summary>
        /// トラップが発生したかどうか
        /// </summary>
        public bool IsTriggered { get; private set; }

        /// <summary>
        /// スピード補正値
        /// </summary>
        public double SpeedCorrection => this.Type.SpeedCorrection;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vType">トラップの種類</param>
        /// <param name="vPosition">トラップ位置</param>
        public TrapEntity(Trap vType, double vPosition) {
            this.Type = vType;
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
