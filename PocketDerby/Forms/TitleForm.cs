using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class TitleForm : Form {
        public TitleForm() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) {
            var wNextForm = new HorseSelectForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }
    }
}
