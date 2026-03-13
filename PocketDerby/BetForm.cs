using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class BetForm : Form {
        public BetForm() {
            InitializeComponent();
        }

        /// <summary>
        /// 掛け金入力画面から購入馬券表示画面へ遷移する
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e) {
            var wNextForm = new TicketForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// 掛け金入力画面から馬選択画面へ遷移する
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e) {
            var wNextForm = new HorseSelectForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }
    }
}
