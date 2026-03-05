namespace PocketDerby.Model {
    /// <summary>
    /// トラップクラス
    /// </summary>
    internal class Trap {

        /// <summary>
        /// トラップの種類
        /// </summary>
        public TrapEnum Type { get; private set; }
        /// <summary>
        /// スピード補正値
        /// </summary>
        public double SpeedCorrection { get; private set; }
        /// <summary>
        /// トラップ発生時のメッセージ
        /// </summary>
        public string TriggerMessage { get; private set; }
        /// <summary>
        /// トラップ回避時のメッセージ
        /// </summary>
        public string AvoidMessage { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vType">トラップの種類</param>
        /// <param name="vSpeedReduction">スピード補正値</param>
        /// <param name="vTriggerMessage">トラップ発生時のメッセージ</param>
        /// <param name="vAvoidMessage">トラップ回避時のメッセージ</param>
        public Trap(TrapEnum vType, double vSpeedReduction, string vTriggerMessage, string vAvoidMessage) {
            this.Type = vType;
            this.SpeedCorrection = vSpeedReduction;
            this.TriggerMessage = vTriggerMessage;
            this.AvoidMessage = vAvoidMessage;
        }

        public static readonly Trap HeadWind =
            new Trap(TrapEnum.HeadWind, 0.9, "おっと！{0}が逆風にあおられた！", "{0}は逆風をものともしない！");
        public static readonly Trap BadTrack =
            new Trap(TrapEnum.BadTrack, 0.8, "おっと！{0}の足元の馬場が悪い！", "{0}は悪い馬場を巧みにかわした！");
        public static readonly Trap Temper =
            new Trap(TrapEnum.Temper, 0.7, "おっと！{0}の気性が荒くなった！", "{0}は冷静さを保っている！");

        public static readonly Trap[] AllTraps = new Trap[] { HeadWind, BadTrack, Temper };
    }
}
