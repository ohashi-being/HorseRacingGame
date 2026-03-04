namespace PocketDerby.Model {
    /// <summary>
    /// ゲームの終了条件を判定するクラス
    /// </summary>
    internal static class GameEndCheck {

        /// <summary>
        /// クリアとなる所持金の条件
        /// </summary>
        private const int C_ClearMoney = 50000;
        /// <summary>
        /// 破産となる所持金の条件
        /// </summary>
        private const int C_LoseMoney = 100;

        /// <summary>
        /// クリア条件、破産条件を満たしているか判定する
        /// </summary>
        /// <returns>各条件に合ったメッセージ</returns>
        public static GameStateEnum CheckGameState(int vPlayerMoney) {

            if (vPlayerMoney >= C_ClearMoney) {
                return GameStateEnum.GameClear;
            }

            if (vPlayerMoney < C_LoseMoney) {
                return GameStateEnum.GameOver;
            }

            return GameStateEnum.Continue;
        }
    }
}

