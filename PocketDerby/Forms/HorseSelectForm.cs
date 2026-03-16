using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class HorseSelectForm : Form {
        public HorseSelectForm() {
            InitializeComponent();
        }

        /// <summary>
        /// 馬選択画面から掛け金入力画面へ遷移する
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e) {
            this.GoNextForm(new BetForm());
        }
    }
}
