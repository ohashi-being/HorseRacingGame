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
            this.GoNextForm(new TicketForm());
        }

        /// <summary>
        /// 掛け金入力画面から馬選択画面へ遷移する
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e) {
            this.GoNextForm(new HorseSelectForm());
        }
    }
}
