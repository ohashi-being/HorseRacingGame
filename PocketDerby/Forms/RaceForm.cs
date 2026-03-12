using System.Windows.Forms;

namespace PocketDerby {
    public partial class RaceForm : Form {
        public RaceForm() {
            InitializeComponent();
        }

        // TODO: レース終了時に呼び出す
        /// <summary>
        /// レース結果画面へ遷移する
        /// </summary>
        private void GoToResultForm() {
            var wNextForm = new ResultForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }
    }
}
