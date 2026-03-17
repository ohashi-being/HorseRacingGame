namespace PocketDerby.Forms {
    /// <summary>
    /// 表示に関するユーティリティクラス
    /// </summary>
    internal static class DisplayHelper {
        /// <summary>
        /// 数字を丸数字に変換する
        /// </summary>
        /// <param name="vNumber">数字</param>
        /// <returns><丸数字の文字列/returns>
        public static string GetCircleNumber(int vNumber) {
            if (vNumber >= 1 && vNumber <= 20) {
                // 丸数字「①」のUnicodeは 0x2460
                return ((char)(0x2460 + vNumber - 1)).ToString();
            }
            return vNumber.ToString();
        }
    }
}
