using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    /// <summary>
    /// レース画面クラス
    /// </summary>
    internal partial class RaceForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// 馬番とPictureBoxの対応マップ
        /// </summary>
        private readonly Dictionary<int, PictureBox> FHorseNumberToPictureBox;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        internal RaceForm(GameManager vGameManager) {
            InitializeComponent();
            this.FGameManager = vGameManager;

            this.FHorseNumberToPictureBox = new Dictionary<int, PictureBox> {
                { 1, this.Horse1PictureBox },
                { 2, this.Horse2PictureBox },
                { 3, this.Horse3PictureBox },
                { 4, this.Horse4PictureBox },
                { 5, this.Horse5PictureBox },
            };
        }

        /// <summary>
        /// フォームがロードされたときに呼び出されるイベントハンドラ
        /// </summary>
        private void RaceForm_Load(object sender, EventArgs e) {
            this.TrapLabel.Text = "";

            SetupTicketInfo();

            this.FGameManager.StartRace();

            this.RaceTimer.Start();
        }

        /// <summary>
        /// 購入した馬券情報を画面に表示する
        /// </summary>
        private void SetupTicketInfo() {
            var wRaceData = this.FGameManager.CurrentRaceData;
            this.HorseNumberLabel.Text = wRaceData.SelectedHorse.Number.ToString();
            this.HorseNameLabel.Text = wRaceData.SelectedHorse.Name;
            this.BetLabel.Text = $"{wRaceData.BetAmount}円";
        }

        /// <summary>
        /// 1フレームごとに呼ばれるレース進行処理
        /// </summary>
        private void RaceTimer_Tick(object sender, EventArgs e) {

            var wMessages = this.FGameManager.TriggerTraps();
            if (wMessages.Count > 0) {
                AddTrapMessages(wMessages);
                this.TrapDisplayTimer.Stop();
                this.TrapDisplayTimer.Start();
            }

            bool wIsFinished = this.FGameManager.UpdateRace();

            UpdateHorsePositions();

            if (wIsFinished) {
                this.RaceTimer.Stop();
                this.TrapDisplayTimer.Stop();
                GoToResultForm();
            }
        }

        /// <summary>
        /// トラップメッセージをラベルに追記する
        /// </summary>
        /// <param name="vMessages">追記するメッセージ一覧</param>
        private void AddTrapMessages(List<string> vMessages) {
            var wNewText = string.Join(Environment.NewLine, vMessages);
            this.TrapLabel.Text = string.IsNullOrEmpty(this.TrapLabel.Text)
                ? wNewText
                : this.TrapLabel.Text + Environment.NewLine + wNewText;
        }

        /// <summary>
        /// トラップメッセージの表示時間が経過したときに呼び出されるイベントハンドラ
        /// </summary>
        private void TrapDisplayTimer_Tick(object sender, EventArgs e) {
            this.TrapLabel.Text = "";
            this.TrapDisplayTimer.Stop();
        }

        /// <summary>
        /// 各馬のPictureBoxの位置を更新する
        /// </summary>
        private void UpdateHorsePositions() {
            var wPositions = this.FGameManager.CurrentRaceData.HorsePositions;

            foreach (var wEntry in wPositions) {
                if (this.FHorseNumberToPictureBox.TryGetValue(wEntry.Key, out var wPictureBox)) {
                    wPictureBox.Left = (int)wEntry.Value;
                }
            }
        }

        /// <summary>
        /// レース終了後、結果画面へ遷移する
        /// </summary>
        private void GoToResultForm() {
            var wResultForm = new ResultForm(this.FGameManager);
            this.Hide();
            wResultForm.ShowDialog();

            if (wResultForm.DialogResult == DialogResult.OK) {
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        /// <summary>
        /// フォームが閉じられるときに呼び出されるイベントハンドラ
        /// </summary>
        private void RaceForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (this.DialogResult != DialogResult.OK) Application.Exit();
        }
    }
}
