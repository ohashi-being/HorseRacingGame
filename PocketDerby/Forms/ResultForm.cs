using System;
using System.Drawing;
using System.Windows.Forms;
using PocketDerby.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    /// <summary>
    /// レース結果画面クラス
    /// </summary>
    internal partial class ResultForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        internal ResultForm(GameManager vGameManager) {
            InitializeComponent();
            this.FGameManager = vGameManager;
        }

        /// <summary>
        /// フォームがロードされたときに呼び出されるイベントハンドラ
        /// </summary>
        private void ResultForm_Load(object sender, EventArgs e) {
            ShowRaceResult();
        }

        /// <summary>
        /// レース結果を画面に表示する
        /// </summary>
        private void ShowRaceResult() {
            SetupListView();

            int wPayout = this.FGameManager.ProcessRaceEnd();

            SetupPayoutDisplay(wPayout);
        }

        /// <summary>
        /// レース結果をListViewに表示する
        /// </summary>
        private void SetupListView() {
            var wRaceData = this.FGameManager.CurrentRaceData;

            for (int i = 0 ; i < wRaceData.RaceResults.Count ; i++) {
                var wItem = CreateResultListItem(i + 1, wRaceData.RaceResults[i]);
                this.ResultListView.Items.Add(wItem);
            }
        }

        /// <summary>
        /// レース結果のListViewの1行を作成する
        /// </summary>
        /// <param name="vRank">着順</param>
        /// <param name="vHorse">対象の馬</param>
        /// <returns>ListViewの1行分</returns>
        private ListViewItem CreateResultListItem(int vRank, Horse vHorse) {
            var wItem = new ListViewItem($"{vRank}");
            wItem.SubItems.Add(DisplayHelper.GetCircleNumber(vHorse.Number));
            wItem.SubItems.Add(vHorse.Name);
            wItem.SubItems.Add(vHorse.Odds.ToString("F1"));
            return wItem;
        }

        /// <summary>
        /// 払戻金の表示を更新する
        /// </summary>
        /// <param name="vPayout">払戻金</param>
        private void SetupPayoutDisplay(int vPayout) {
            if (vPayout > 0) {
                this.HitStatusLabel.Text = "的中！";
                this.HitStatusLabel.ForeColor = Color.Red;
                this.PayoutLabel.Text = $"払戻金: {vPayout}円";
            } else {
                this.HitStatusLabel.Text = "はずれ...";
                this.HitStatusLabel.ForeColor = Color.Blue;
                this.PayoutLabel.Text = "払戻金: 0円";
            }
            this.CurrentMoneyLabel.Text = $"所持金：{this.FGameManager.PlayerMoney.Money}円";
        }

        /// <summary>
        /// レース結果画面から馬選択画面へ遷移する
        /// </summary>
        private void NextRaceButton_Click(object sender, EventArgs e) {
            if (IsGameOver()) return;
            this.DialogResult = DialogResult.OK;
            this.GoNextForm(new HorseSelectForm(this.FGameManager));
        }

        /// <summary>
        /// ゲームオーバーかどうかを判定する
        /// </summary>
        /// <returns>ゲームオーバーかどうか</returns>
        private bool IsGameOver() {
            if (this.FGameManager.PlayerMoney.Money >= BetCalculator.C_MinBetAmount) return false;
            MessageBox.Show("ゲームオーバー！", "破産", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
            return true;
        }

        /// <summary>
        /// ゲームを終了する
        /// </summary>
        private void FinishButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// フォームが閉じられるときに呼び出されるイベントハンドラ
        /// </summary>
        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (this.DialogResult != DialogResult.OK) Application.Exit();
        }
    }
}
