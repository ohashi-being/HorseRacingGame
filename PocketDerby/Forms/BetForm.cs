using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class BetForm : Form {
        public BetForm() {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            var wNextForm = new TicketForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e) {
            var wNextForm = new HorseSelectForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }
    }
}
