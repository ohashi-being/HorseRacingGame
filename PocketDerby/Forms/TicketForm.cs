using System;
using System.Windows.Forms;

namespace PocketDerby {
    public partial class TicketForm : Form {
        public TicketForm() {
            InitializeComponent();
        }

        /// <summary>
        /// 購入馬券表示画面からレース画面へ遷移する
        /// </summary>
        private void GoRaceButton_Click(object sender, EventArgs e) {
            this.GoNextForm(new RaceForm());
        }
    }
}
