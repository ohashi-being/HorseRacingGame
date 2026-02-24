using System;
using System.Collections.Generic;

namespace アプリ画面作成.Model {
    /// <summary>
    /// トラップの種類
    /// </summary>
    internal enum TrapTypeEnum {
        /// <summary>
        /// 逆風
        /// </summary>
        HeadWind,
        /// <summary>
        /// 馬場が悪い
        /// </summary>
        BadTrack,
        /// <summary>
        /// 気性が荒くなる
        /// </summary>
        Temper
    }

    /// <summary>
    /// レース中に発生するトラップを表す
    /// </summary>
    internal class Trap {
        private static readonly Random FRandom = new Random();

        #region 定数
        /// <summary>
        /// 各馬に割り当てるトラップの数
        /// </summary>
        public const int C_TrapCountPerHorse = 3;
        /// <summary>
        /// 各トラップ間の最低距離
        /// </summary>
        public const double C_MinDistance = 100.0;
        /// <summary>
        /// トラップの効果時間
        /// </summary>
        public const double C_EffectDuration = 2.0;
        #endregion

        #region 種類ごとの定義テーブル
        /// <summary>
        /// トラップ種類ごとのスピード補正値
        /// </summary>
        private static readonly Dictionary<TrapTypeEnum, double> FTrapToSpeedCorrection
            = new Dictionary<TrapTypeEnum, double> {
                { TrapTypeEnum.HeadWind, 0.9 },
                { TrapTypeEnum.BadTrack, 0.8 },
                { TrapTypeEnum.Temper,   0.7 }
            };

        /// <summary>
        /// トラップ種類ごとの発動メッセージ（{0} = 馬名）
        /// </summary>
        private static readonly Dictionary<TrapTypeEnum, string> FTrapToTrapMessage
            = new Dictionary<TrapTypeEnum, string> {
                { TrapTypeEnum.HeadWind, "おっと！{0}が逆風にあおられた！" },
                { TrapTypeEnum.BadTrack, "{0}の足元の馬場が悪い！" },
                { TrapTypeEnum.Temper,   "おっと！{0}の気性が荒くなった！" }
            };

        /// <summary>
        /// トラップ種類ごとの回避メッセージ（{0} = 馬名）
        /// </summary>
        private static readonly Dictionary<TrapTypeEnum, string> FTrapToAvoidMessage
            = new Dictionary<TrapTypeEnum, string> {
                { TrapTypeEnum.HeadWind, "{0}は逆風をものともしない！" },
                { TrapTypeEnum.BadTrack, "{0}は悪い馬場を巧みにかわした！" },
                { TrapTypeEnum.Temper,   "{0}は冷静さを保っている！" }
            };
        #endregion

        /// <summary>
        /// トラップの種類
        /// </summary>
        public TrapTypeEnum Type { get; private set; }
        /// <summary>
        /// トラップ発生位置
        /// </summary>
        public double Position { get; private set; }
        /// <summary>
        /// スピード補正値
        /// </summary>
        public double SpeedCorrection { get; private set; }
        /// <summary>
        /// トラップが発動したかどうか
        /// </summary>
        public bool IsTriggered { get; set; }
        /// <summary>
        /// トラップが回避されたかどうか
        /// </summary>
        public bool IsAvoided { get; set; }
        /// <summary>
        /// トラップの効果が持続しているかどうか
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// トラップ効果の残り時間
        /// </summary>
        public double RemainingTime { get; set; }

        /// <summary>
        /// トラップ発生時の実況メッセージを取得する
        /// </summary>
        public string GetTriggerMessage(string vHorseName) {
            return string.Format(FTrapToTrapMessage[this.Type], vHorseName);
        }

        /// <summary>
        /// トラップ回避時の実況メッセージを取得する
        /// </summary>
        public string GetAvoidMessage(string vHorseName) {
            return string.Format(FTrapToAvoidMessage[this.Type], vHorseName);
        }

        /// <summary>
        /// 回避判定を行う
        /// </summary>
        public bool TryAvoid(int vLuck) {
            return vLuck > FRandom.Next(1, 101);
        }

        /// <summary>
        /// 1頭分のトラップを生成する
        /// </summary>
        public static List<Trap> GenerateTraps() {
            var wPositions = GeneratePositions(C_TrapCountPerHorse);
            var wTypes = new List<TrapTypeEnum> {
                TrapTypeEnum.HeadWind,
                TrapTypeEnum.BadTrack,
                TrapTypeEnum.Temper
            };
            ShuffleList(wTypes);

            var wTraps = new List<Trap>();
            for (int i = 0 ; i < C_TrapCountPerHorse ; i++) {
                var wType = wTypes[i];
                wTraps.Add(new Trap {
                    Type = wType,
                    Position = wPositions[i],
                    SpeedCorrection = FTrapToSpeedCorrection[wType],
                    IsTriggered = false,
                    IsAvoided = false,
                    IsActive = false,
                    RemainingTime = 0
                });
            }
            return wTraps;
        }

        /// <summary>
        /// 100px以上離れた発生位置をランダムに生成する
        /// </summary>
        private static List<double> GeneratePositions(int vCount) {
            var positions = new List<double>();

            double wMin = 50.0;
            double wMax = GameState.C_CourseDistance - 100.0;

            double wUsableLength = wMax - wMin;
            double wRequiredLength = C_MinDistance * ( vCount - 1 );

            if (wRequiredLength > wUsableLength) {
                vCount = (int)( wUsableLength / C_MinDistance ) + 1;
            }

            double freeSpace = wUsableLength - C_MinDistance * ( vCount - 1 );

            var randomFactors = new List<double>();
            for (int i = 0 ; i < vCount ; i++)
                randomFactors.Add(FRandom.NextDouble());

            randomFactors.Sort();

            for (int i = 0 ; i < vCount ; i++) {
                double basePos = wMin + i * C_MinDistance;
                double offset = randomFactors[i] * freeSpace;
                positions.Add(basePos + offset);
            }

            return positions;
        }

        /// <summary>
        /// リストをシャッフルする
        /// </summary>
        private static void ShuffleList<T>(List<T> vList) {
            for (int i = vList.Count - 1 ; i > 0 ; i--) {
                int j = FRandom.Next(i + 1);
                T wTemp = vList[i];
                vList[i] = vList[j];
                vList[j] = wTemp;
            }
        }

        /// <summary>
        /// 馬がトラップに到達したかを判定し、発動処理を行う
        /// </summary>
        /// <param name="vHorse"></param>
        /// <param name="vDeltaTime"></param>
        /// <returns></returns>
        public bool TryTrigger(Horse vHorse, double vDeltaTime) {
            if (this.IsTriggered) return false;

            if (vHorse.Position >= this.Position) {
                this.IsTriggered = true;

                if (TryAvoid(vHorse.Luck)) {
                    this.IsAvoided = true;
                    return true;
                }

                this.IsActive = true;
                this.RemainingTime = C_EffectDuration;

                vHorse.SpeedCorrection *= this.SpeedCorrection;

                return true;
            }

            return false;
        }
    }
}
