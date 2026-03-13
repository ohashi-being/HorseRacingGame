namespace PocketDerby.Model {
    /// <summary>
    /// 賭け金の計算を行うクラス
    /// </summary>
    internal static class BetCalculator {

        /// <summary>
        /// 賭け金の最小値
        /// </summary>
        private const int C_MinBetAmount = 100;

        /// <summary>
        /// 賭け金の単位
        /// </summary>
        private const int C_BetAmountUnit = 100;

        /// <summary>
        /// 賭け金が有効かどうかを検証する
        /// </summary>
        /// <param name="vBetAmount">検証する賭け金</param>
        /// <param name="vPlayerMoney">プレイヤーの所持金</param>
        /// <returns>有効な場合はtrue、無効な場合はfalse</returns>
        public static bool IsValidBetAmount(int vBetAmount, int vPlayerMoney) => vBetAmount <= vPlayerMoney && C_MinBetAmount <= vBetAmount && vBetAmount % C_BetAmountUnit == 0;

        /// <summary>
        /// 賭け金に関するエラーメッセージを取得する
        /// </summary>
        /// <param name="vPlayerMoney">プレイヤーの所持金</param>
        /// <returns>有効な賭け金の範囲と単位を示すエラーメッセージ</returns>
        public static string GetBetAmountErrorMessage(int vPlayerMoney) => $"賭け金は{C_MinBetAmount}円以上{vPlayerMoney}円以下で、{C_BetAmountUnit}円単位で入力してください。";

        /// <summary>
        /// 賭け金とオッズから払戻金を計算する
        /// </summary>
        /// <param name="vBetAmount">賭け金</param>
        /// <param name="vOdds">的中した馬のオッズ</param>
        /// <returns>払戻金</returns>
        public static int CalculatePayout(int vBetAmount, double vOdds) {
            return (int)(vBetAmount * vOdds);
        }
    }
}
