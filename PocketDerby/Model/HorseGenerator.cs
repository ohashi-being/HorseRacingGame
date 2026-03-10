using System;
using System.Collections.Generic;

namespace PocketDerby.Model {
    /// <summary>
    /// 馬生成クラス
    /// </summary>
    internal static class HorseGenerator {

        /// <summary>
        /// スピードの最小値
        /// </summary>
        private const int C_MinSpeed = 50;
        /// <summary>
        /// スピードの最大値
        /// </summary>
        private const int C_MaxSpeed = 100;
        /// <summary>
        /// 運の良さの最小値
        /// </summary>
        private const int C_MinLuck = 0;
        /// <summary>
        /// 運の良さの最大値
        /// </summary>
        private const int C_MaxLuck = 100;

        /// <summary>
        /// 乱数生成用のRandomインスタンス
        /// </summary>
        private static readonly Random FRandom = new Random();

        /// <summary>
        /// 出走馬を生成する
        /// </summary>
        /// <param name="vHorseCount">生成する馬の数</param>
        /// <returns>生成された馬のリスト</returns>
        public static List<Horse> GenerateHorses(int vHorseCount) {

            var wHorses = new List<Horse>();
            var wHorseNames = HorseNameMaster.GetRandomNames(vHorseCount);


            for (int i = 0 ; i < vHorseCount ; i++) {
                int wNumber = i + 1;
                string wName = wHorseNames[i];
                int wSpeed = FRandom.Next(C_MinSpeed, C_MaxSpeed + 1);
                int wLuck = FRandom.Next(C_MinLuck, C_MaxLuck + 1);

                var wHorse = new Horse(wNumber, wName, wLuck, wSpeed);
                wHorses.Add(wHorse);
            }
            return wHorses;
        }
    }
}
