namespace PocketDerby.Model {
    /// <summary>
    /// レースの規約をまとめた定数クラス
    /// </summary>
    internal static class RaceRegulation {

        /// <summary>
        /// スタート位置
        /// </summary>
        public const double C_StartPosition = 86.0;

        // タスク #602513: レース進行クラスの実装がマージされ次第反映
        /// <summary>
        /// ゴール位置
        /// </summary>
        public const double C_GoalPosition = 600.0;

        /// <summary>
        /// トラップ間の最低距離
        /// </summary>
        public const double C_MinDistance = 100.0;
        /// <summary>
        /// トラップ発生位置の最大値
        /// </summary>
        public const double C_TrapPositionMax = 500.0;
        /// <summary>
        /// 回避率の基本確率
        /// </summary>
        public const double C_AvoidRateBase = 0.25;
        /// <summary>
        /// 運の良さによる回避率の変動係数
        /// </summary>
        public const double C_AvoidRateLuckFactor = 0.005;
    }
}