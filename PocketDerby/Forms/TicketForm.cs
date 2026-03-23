using System;
using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    internal partial class TicketForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        public TicketForm(GameManager vGameManager) {
            InitializeComponent();

            this.FGameManager = vGameManager;
        }

        /// <summary>
        /// 購入馬券表示画面からレース画面へ遷移する
        /// </summary>
        private void GoRaceButton_Click(object sender, EventArgs e) {
            this.GoNextForm(new RaceForm());
        }
    }
}
