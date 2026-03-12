using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class ResultForm : Form {
        public ResultForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var wNextForm = new HorseSelectForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
