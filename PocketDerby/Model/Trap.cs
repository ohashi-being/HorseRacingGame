using System.Collections.Generic;

namespace PocketDerby.Model {
    /// <summary>
    /// トラップクラス
    /// </summary>
    internal class Trap {

        /// <summary>
        /// スピード補正値
        /// </summary>
        public double SpeedCorrection { get; }
        /// <summary>
        /// トラップ発生時のメッセージ
        /// </summary>
        private readonly string FTriggerMessage;
        /// <summary>
        /// トラップ回避時のメッセージ
        /// </summary>
        private readonly string FAvoidMessage;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vSpeedCorrection">スピード補正値</param>
        /// <param name="vTriggerMessage">トラップ発生時のメッセージ</param>
        /// <param name="vAvoidMessage">トラップ回避時のメッセージ</param>
        private Trap(double vSpeedCorrection, string vTriggerMessage, string vAvoidMessage) {
            this.SpeedCorrection = vSpeedCorrection;
            this.FTriggerMessage = vTriggerMessage;
            this.FAvoidMessage = vAvoidMessage;
        }

        /// <summary>
        /// トラップ発生時のメッセージを取得する
        /// </summary>
        /// <param name="vHorseName">馬の名前</param>
        /// <returns>トラップ発生時のメッセージ</returns>
        public string GetTriggerMessage(string vHorseName) => string.Format(FTriggerMessage, vHorseName);

        /// <summary>
        /// トラップ回避時のメッセージを取得する
        /// </summary>
        /// <param name="vHorseName">馬の名前</param>
        /// <returns>トラップ回避時のメッセージ</returns>
        public string GetAvoidMessage(string vHorseName) => string.Format(FAvoidMessage, vHorseName);

        public static readonly Trap C_HeadWind =
            new Trap(0.9, "おっと！{0}が逆風にあおられた！", "{0}は逆風をものともしない！");
        public static readonly Trap C_BadTrack =
            new Trap(0.8, "おっと！{0}の足元の馬場が悪い！", "{0}は悪い馬場を巧みにかわした！");
        public static readonly Trap C_Temper =
            new Trap(0.7, "おっと！{0}の気性が荒くなった！", "{0}は冷静さを保っている！");

        public static readonly IReadOnlyList<Trap> C_AllTraps = new Trap[] { C_HeadWind, C_BadTrack, C_Temper };
    }
}
