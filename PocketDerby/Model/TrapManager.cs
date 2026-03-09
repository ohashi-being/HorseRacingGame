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
        /// 馬番をキーとするトラップ一覧
        /// </summary>
        private readonly Dictionary<int, IReadOnlyList<TrapEntity>> FHorseToTraps = new Dictionary<int, IReadOnlyList<TrapEntity>>();

        /// <summary>
        /// 馬番からトラップへのマップ
        /// </summary>
        public IReadOnlyDictionary<int, IReadOnlyList<TrapEntity>> HorseToTraps => this.FHorseToTraps;

        /// <summary>
        /// 全馬のトラップを生成する
        /// </summary>
        /// <param name="vHorses">馬のリスト</param>
        public void CreateTraps(IReadOnlyCollection<Horse> vHorses) {

            this.FHorseToTraps.Clear();

            foreach (var wHorse in vHorses) {
                FHorseToTraps[wHorse.Number] = CreateTrapsForHorse();
            }
        }

        /// <summary>
        /// 1頭分のトラップを生成する
        /// </summary>
        /// <returns>生成したトラップのリスト</returns>
        private List<TrapEntity> CreateTrapsForHorse() {

            var wTraps = new List<TrapEntity>();
            var wTrapCount = Trap.C_AllTraps.Count;

            var wInterval = (RaceRegulation.C_TrapPositionMax - RaceRegulation.C_StartPosition) / wTrapCount;
            var wShuffled = Trap.C_AllTraps.OrderBy(x => random.Next()).ToArray();

            for (var i = 0 ; i < wTrapCount ; i++) {
                var wPosition = RaceRegulation.C_StartPosition + wInterval * i + random.NextDouble() * (wInterval - RaceRegulation.C_MinDistance);
                wTraps.Add(new TrapEntity(wShuffled[i], wPosition));
            }

            return wTraps;
        }

        /// <summary>
        /// トラップの回避率を計算する
        /// </summary>
        /// <param name="vHorseLuck">運の良さ</param>
        /// <returns>トラップの回避率</returns>
        private double CalculateAvoidRate(int vHorseLuck) {
            return RaceRegulation.C_AvoidRateBase + vHorseLuck * RaceRegulation.C_AvoidRateLuckFactor;
        }

        /// <summary>
        /// トラップの回避判定を行う
        /// </summary>
        /// <param name="vHorseLuck">対象の馬の運の良さ</param>
        /// <returns>回避成功したかどうか</returns>
        public bool IsAvoided(int vHorseLuck) {
            return random.NextDouble() < CalculateAvoidRate(vHorseLuck);
        }

        /// <summary>
        /// 馬の現在位置に応じて、新しく踏んだトラップを取得する
        /// </summary>
        /// <param name="vHorseNumber">対象の馬の馬番</param>
        /// <param name="vCurrentPosition">現在位置</param>
        /// <returns>現在位置にある未実行のトラップ（該当なしの場合はnull）</returns>
        public TrapEntity GetTrap(int vHorseNumber, double vCurrentPosition) {
            if (!this.HorseToTraps.TryGetValue(vHorseNumber, out var wTraps)) {
                throw new ArgumentException($"指定された馬番({vHorseNumber})のトラップ情報が存在しません。", nameof(vHorseNumber));
            }
            
            return wTraps.FirstOrDefault(x => !x.IsTriggered && x.Position <= vCurrentPosition);

        }
    }
}