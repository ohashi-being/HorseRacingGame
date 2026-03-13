using System;

namespace PocketDerby.Model {
    /// <summary>
    /// ユーザーの所持金クラス
    /// </summary>
    internal class PlayerMoney {

        /// <summary>
        /// 初期所持金
        /// </summary>
        public const int C_InitialMoney = 10000;

        /// <summary>
        /// 現在の所持金
        /// </summary>
        public int Money { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PlayerMoney() {
            this.Money = C_InitialMoney;
        }

        /// <summary>
        /// 所持金を増やす
        /// </summary>
        /// <param name="vAmount">増やす金額</param>
        public void AddMoney(int vAmount) {
            if (vAmount < 0) {
                throw new ArgumentException("増やす金額は0以上でなければなりません。");
            }
            this.Money += vAmount;
        }

        /// <summary>
        /// 所持金を減らす
        /// </summary>
        /// <param name="vAmount">減らす金額</param>
        public void SubtractMoney(int vAmount) {
            if (vAmount > this.Money) {
                throw new InvalidOperationException("所持金が不足しています。");
            }
            this.Money -= vAmount;
        }
    }
}
