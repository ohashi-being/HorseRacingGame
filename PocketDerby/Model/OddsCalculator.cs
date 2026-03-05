using System;
using System.Collections.Generic;

namespace PocketDerby.Model {
    /// <summary>
    /// オッズ計算を行うクラス
    /// </summary>
    internal static class OddsCalculator {

        /// <summary>
        /// オッズバランス調整用の係数
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
        public static void CalculateOdds(List<Horse> vHorses) {
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

            for (int i = 0 ; i < vHorses.Count ; i++) {
                if (wEffectiveSpeeds[i] <= 0) {
                    throw new InvalidOperationException($"馬番号{vHorses[i].Number}の実効スピードが0以下です。");
                }
                double wRawOdds = ( wEffectiveSpeedAverage / wEffectiveSpeeds[i] ) * C_OddsCoefficient;
                vHorses[i].Odds = Math.Max(Math.Round(wRawOdds, 2), C_MinimumOdds);
            }
        }

        /// <summary>
        /// 実効スピードを算出する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        /// <returns>実効スピード</returns>
        private static double CalculateEffectiveSpeed(Horse vHorse) {
            return vHorse.Speed * ( 1 + vHorse.Luck * C_LuckCoefficient );
        }
    }
}
