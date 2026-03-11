namespace PocketDerby.Model {
    /// <summary>
    /// レースの規約をまとめた定数クラス
    /// </summary>
    internal static class RaceRegulation {

        /// <summary>
        /// コースの長さ
        /// </summary>
        public const double C_CourseLength = 614.0;

        /// <summary>
        /// スタート位置
        /// </summary>
        public const double C_StartPosition = 86.0;

        /// <summary>
        /// ゴール位置
        /// </summary>
        public const double C_GoalPosition = C_StartPosition + C_CourseLength;

        /// <summary>
        /// トラップ間の最低距離
        /// </summary>
        public const double C_MinDistance = 100.0;
        /// <summary>
        /// トラップ発生位置の最大値
        /// </summary>
        public const double C_TrapPositionMax = C_GoalPosition - C_MinDistance;
        /// <summary>
        /// 回避率の基本確率
        /// </summary>
        public const double C_AvoidRateBase = 0.25;
        /// <summary>
        /// 運の良さによる回避率の変動係数
        /// </summary>
        public const double C_AvoidRateLuckFactor = 0.005;

        /// <summary>
        /// 馬のスピード補正値の基準値
        /// </summary>
        public const double C_HorseSpeedCorrectionBase = 1.0;
    }
}