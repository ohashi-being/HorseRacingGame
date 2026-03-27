using System;
using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    /// <summary>
    /// 購入馬券表示画面クラス
    /// </summary>
    internal partial class TicketForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        internal TicketForm(GameManager vGameManager) {
            InitializeComponent();

            this.FGameManager = vGameManager;
        }

        /// <summary>
        /// フォームがロードされたときに呼び出されるイベントハンドラ
        /// </summary>
        private void TicketForm_Load(object sender, System.EventArgs e) {
            SetupTicketInfo();
        }

        /// <summary>
        /// チケット情報をフォームに表示するためのメソッド
        /// </summary>
        private void SetupTicketInfo() {
            var wRaceData = this.FGameManager.CurrentRaceData;

            Horse wSelectedHorse = wRaceData.SelectedHorse;

            int wBetAmount = wRaceData.BetAmount;

            this.HorseNumberLabel.Text = wSelectedHorse.Number.ToString();
            this.HorseNameLabel.Text = wSelectedHorse.Name;
            this.BetLabel.Text = $"{wBetAmount}円";
        }

        /// <summary>
        /// 購入馬券表示画面からレース画面へ遷移する
        /// </summary>
        private void GoRaceButton_Click(object sender, EventArgs e) {
<<<<<<< feature/#602526
            var wRaceForm = new RaceForm(this.FGameManager);
            this.Hide();
            wRaceForm.ShowDialog();

            if (wRaceForm.DialogResult == DialogResult.OK) {
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        /// <summary>
        /// フォームが閉じられるときに呼び出されるイベントハンドラ
        /// </summary>
        private void TicketForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (this.DialogResult != DialogResult.OK) Application.Exit();
=======
            this.GoNextForm(new RaceForm(this.FGameManager));
>>>>>>> develop
        }
    }
}
