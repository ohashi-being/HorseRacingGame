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
        public static bool ValidateBetAmount(int vBetAmount, int vPlayerMoney, out string vErrorMessage) {

            // 掛け金が所持金を超えた場合
            if (vBetAmount > vPlayerMoney) {
                vErrorMessage = $"賭け金は{C_MinBetAmount}以上{vPlayerMoney}以下で、{C_BetAmountUnit}単位で入力してください。";
                return false;
            }

            // 最小賭け金を下回った場合
            if (vBetAmount < C_MinBetAmount) {
                vErrorMessage = $"賭け金は{C_MinBetAmount}以上{vPlayerMoney}以下で、{C_BetAmountUnit}単位で入力してください。";
                return false;
            }

            // 賭け金が100円単位でない場合
            if (vBetAmount % C_BetAmountUnit != 0) {
                vErrorMessage = $"賭け金は{C_MinBetAmount}以上{vPlayerMoney}以下で、{C_BetAmountUnit}単位で入力してください。";
                return false;
            }

            vErrorMessage = string.Empty;
            return true;
        }

        /// <summary>
        /// 賭け金とオッズから払戻金を計算する
        /// </summary>
        /// <param name="vBetAmount">賭け金</param>
        /// <param name="vOdds">的中した馬のオッズ</param>
        /// <returns>払戻金</returns>
        public static int CalculatePayout(int vBetAmount, double vOdds) {
            return (int)( vBetAmount * vOdds );
        }
    }
}
