using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class TicketForm : Form {
        public TicketForm() {
            InitializeComponent();
        }

        private void GoRaceButton_Click(object sender, EventArgs e) {
            var wNextForm = new RaceForm();
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();
        }
    }
}
