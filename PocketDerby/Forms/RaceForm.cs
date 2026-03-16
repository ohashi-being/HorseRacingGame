using System.Windows.Forms;

namespace PocketDerby {
    public partial class RaceForm : Form {
        public RaceForm() {
            InitializeComponent();
        }

        /// <summary>
        /// レース終了後、結果画面へ遷移する
        /// </summary>
        private void GoToResultForm() {
            this.GoNextForm(new ResultForm());
        }
    }
}
