using System;
﻿using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    internal partial class TicketForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private GameManager FGameManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManeger">ゲーム全体を管理するGameManagerインスタンス</param>
        public TicketForm(GameManager vGameManeger) {
            InitializeComponent();

            this.FGameManager = vGameManeger;
        }

        /// <summary>
        /// 購入馬券表示画面からレース画面へ遷移する
        /// </summary>
        private void GoRaceButton_Click(object sender, EventArgs e) {
            this.GoNextForm(new RaceForm());
        }
    }
}
