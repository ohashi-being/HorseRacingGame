using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketDerby.Model {
    /// <summary>
    /// トラップを管理するクラス
    /// </summary>
    internal class TrapManager {

        private static readonly Random random = new Random();

        /// <summary>
        /// 1頭あたりのトラップの数
        /// </summary>
        public const int C_CountPerHorse = 3;
        /// <summary>
        /// トラップ間の最低距離
        /// </summary>
        public const double C_MinDistance = 100.0;
        /// <summary>
        /// トラップ発生位置の最大値
        /// </summary>
        private const double C_TrapPositionMax = 500.0;
        /// <summary>
        /// 回避率の基本確率
        /// </summary>
        private const double C_AvoidRateBase = 0.25;
        /// <summary>
        /// 運の良さによる回避率の変動係数
        /// </summary>
        private const double C_AvoidRateLuckFactor = 0.005;

        /// <summary>
        /// 馬番をキーとするトラップ一覧
        /// </summary>
        public IReadOnlyDictionary<int, IReadOnlyList<TrapEntity>> HorseTraps { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TrapManager() {
            this.HorseTraps = new Dictionary<int, IReadOnlyList<TrapEntity>>();
        }

        /// <summary>
        /// 全馬のトラップを生成する
        /// </summary>
        /// <param name="vRaceData">レースデータ</param>
        public void CreateTraps(RaceData vRaceData) {

            var wHorseTraps = new Dictionary<int, IReadOnlyList<TrapEntity>>();

            foreach (var wHorse in vRaceData.Horses) {
                wHorseTraps[wHorse.Number] = CreateTrapsForHorse(wHorse);
            }

            this.HorseTraps = wHorseTraps;

        }

        /// <summary>
        /// 1頭分のトラップを生成する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        /// <returns>生成したトラップのリスト</returns>
        private List<TrapEntity> CreateTrapsForHorse(Horse vHorse) {

            var wTraps = new List<TrapEntity>();
            var wInterval = (C_TrapPositionMax - RaceData.C_StartPosition) / C_CountPerHorse;
            var wShuffled = Trap.AllTraps.OrderBy(x => random.Next()).ToArray();

            for (var i = 0 ; i < C_CountPerHorse ; i++) {
                var wPosition = RaceData.C_StartPosition + wInterval * i + random.NextDouble() * (wInterval - C_MinDistance);
                wTraps.Add(new TrapEntity(wShuffled[i], wPosition, vHorse.Name));
            }

            return wTraps;
        }

        /// <summary>
        /// トラップの回避率を計算する
        /// </summary>
        /// <param name="vHorse">馬</param>
        /// <returns>トラップの回避率</returns>
        private double CalculateAvoidRate(Horse vHorse) {
            return C_AvoidRateBase + vHorse.Luck * C_AvoidRateLuckFactor;
        }

        /// <summary>
        /// トラップの回避判定を行う
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        /// <returns>回避成功したかどうか</returns>
        public bool IsAvoided(Horse vHorse) {
            return random.NextDouble() < CalculateAvoidRate(vHorse);
        }

        /// <summary>
        /// 馬の現在位置に応じて、新しく踏んだトラップを取得する
        /// </summary>
        /// <param name="vHorse">対象の馬</param>
        /// <param name="vCurrentPosition">現在位置</param>
        /// <returns>踏んだトラップ（該当なしの場合はnull）</returns>
        public TrapEntity GetTrap(Horse vHorse, double vCurrentPosition) {
            if (!this.HorseTraps.TryGetValue(vHorse.Number, out var wTraps)) {
                return null;
            }
            var wTrap = wTraps.FirstOrDefault(x => !x.IsTriggered && x.Position <= vCurrentPosition);

            if (wTrap != null) {
                wTrap.SetTriggered();
            }

            return wTrap;
        }
    }
}