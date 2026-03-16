using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class ResultForm : Form {
        public ResultForm() {
            InitializeComponent();
        }

        /// <summary>
        /// レース結果結果画面から馬選択画面へ遷移する
        /// </summary>
        private void button1_Click(object sender, EventArgs e) {
            this.GoNextForm(new HorseSelectForm());
        }

        /// <summary>
        /// ゲームを終了する
        /// </summary>
        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
