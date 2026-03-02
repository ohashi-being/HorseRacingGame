namespace PocketDerby.Model {
    /// <summary>
    /// ユーザーの所持金クラス
    /// </summary>
    internal class PlayerMoney {

        /// <summary>
        /// 初期所持金
        /// </summary>
        public const int C_InitialMoney = 10000;

        /// <summary>
        /// 現在の所持金
        /// </summary>
        public int Money { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PlayerMoney() {
            this.Money = C_InitialMoney;
        }
    }
}
