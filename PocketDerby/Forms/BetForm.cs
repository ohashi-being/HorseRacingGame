using System;
using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    public partial class BetForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// 選択された馬
        /// </summary>
        private readonly Horse FSelectedHorse;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        /// <param name="vSelectedHorse">馬選択画面で選択された馬</param>
        internal BetForm(GameManager vGameManager, Horse vSelectedHorse) {
            InitializeComponent();
            this.FGameManager = vGameManager;
            this.FSelectedHorse = vSelectedHorse;
        }

        /// <summary>
        /// 掛け金入力画面から購入馬券表示画面へ遷移する
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e) {

            int wBetAmount = (int)this.BetNumericUpDown.Value;

            if (wBetAmount == 0) {
                MessageBox.Show("賭け金を入力してください！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.FGameManager.TryBuyTicket(this.FSelectedHorse, wBetAmount, out string wErrorMessage)) {
                MessageBox.Show(wErrorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.GoNextForm(new TicketForm(this.FGameManager));
        }

        /// <summary>
        /// 掛け金入力画面から馬選択画面へ遷移する
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
