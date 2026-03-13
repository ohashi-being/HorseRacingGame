using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class TitleForm : Form {
        public TitleForm() {
            InitializeComponent();
        }

        /// <summary>
        /// タイトル画面から馬選択画面へ遷移する
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e) {
            var wNextForm = new HorseSelectForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }
    }
}
