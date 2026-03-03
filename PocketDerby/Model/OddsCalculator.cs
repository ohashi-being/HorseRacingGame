using System;
using System.Collections.Generic;

namespace PocketDerby.Model {
    /// <summary>
    /// オッズ計算を行うクラス
    /// </summary>
    internal static class OddsCalculator {

        /// <summary>
        /// オッズ係数
        /// </summary>
        private const double C_OddsCoefficient = 2.1;
        /// <summary>
        /// 最低オッズ
        /// </summary>
        private const double C_MinimumOdds = 1.1;
        /// <summary>
        /// 運の良さの補正
        /// </summary>
        private const double C_LuckCoefficient = 0.002;

        /// <summary>
        /// 全馬のオッズを算出する
        /// </summary>
        /// <returns>馬番をキーとしたオッズの辞書</returns>
        public static Dictionary<int, double> CalculateOdds(List<Horse> vHorses) {
            if (vHorses == null || vHorses.Count == 0) {
                throw new ArgumentException("馬のリストが空です。", nameof(vHorses));
            }

            double wTotalEffectiveSpeed = 0;
            double[] wEffectiveSpeeds = new double[vHorses.Count];

            for (int i = 0 ; i < vHorses.Count ; i++) {
                wEffectiveSpeeds[i] = CalculateEffectiveSpeed(vHorses[i]);
                wTotalEffectiveSpeed += wEffectiveSpeeds[i];
            }

            double wEffectiveSpeedAverage = wTotalEffectiveSpeed / vHorses.Count;

            var wOddsDict = new Dictionary<int, double>();
            for (int i = 0 ; i < vHorses.Count ; i++) {
                double wRawOdds = ( wEffectiveSpeedAverage / wEffectiveSpeeds[i] ) * C_OddsCoefficient;
                wOddsDict[vHorses[i].Number] = Math.Max(Math.Round(wRawOdds, 2), C_MinimumOdds);
            }

            return wOddsDict;
        }

        /// <summary>
        /// 実効スピードを算出する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        /// <returns>実効スピード</returns>
        public static double CalculateEffectiveSpeed(Horse vHorse) {
            if (vHorse == null) {
                throw new ArgumentNullException(nameof(vHorse));
            }
            return vHorse.Speed * ( 1 + vHorse.Luck * C_LuckCoefficient );
        }
    }
}
