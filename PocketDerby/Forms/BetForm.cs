using System;
using System.Drawing;
using System.Windows.Forms;
using PocketDerby.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    /// <summary>
    /// 掛け金入力画面クラス
    /// </summary>
    internal partial class BetForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// 選択された馬
        /// </summary>
        private readonly Horse FSelectedHorse;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        /// <param name="vSelectedHorse">馬選択画面で選択された馬</param>
        internal BetForm(GameManager vGameManager, Horse vSelectedHorse) {
            InitializeComponent();
            this.FGameManager = vGameManager;
            this.FSelectedHorse = vSelectedHorse;

            this.BetNumericUpDown.Minimum = BetCalculator.C_MinBetAmount;
            this.BetNumericUpDown.Increment = BetCalculator.C_BetAmountUnit;
        }

        /// <summary>
        /// フォームがロードされたときに呼び出されるイベントハンドラ
        /// </summary>
        private void BetForm_Load(object sender, EventArgs e) {
            SetupHorseInfo();
            SetupMoneyInfo();

            UpdatePayoutLabel();
        }

        /// <summary>
        /// 選択された馬の情報をフォームに表示する
        /// </summary>
        private void SetupHorseInfo() {
            this.HorseNameLabel.Text = this.FSelectedHorse.Name;
            this.HorseNumberLabel.Text = DisplayHelper.GetCircleNumber(this.FSelectedHorse.Number);
            this.SpeedValueLabel.Text = this.FSelectedHorse.Speed.ToString();
            this.LuckValueLabel.Text = this.FSelectedHorse.Luck.ToString();
            this.OddsValueLabel.Text = this.FSelectedHorse.Odds.ToString("0.0");

            if (Properties.Resources.ResourceManager.GetObject($"Horse{this.FSelectedHorse.Number}") is Image wImage) {
                this.HorsePictureBox.Image = wImage;
                this.HorsePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        /// <summary>
        /// プレイヤーの所持金をフォームに表示する
        /// </summary>
        private void SetupMoneyInfo() {
            int wCurrentMoney = this.FGameManager.PlayerMoney.Money;
            this.CurrentMoneyLabel.Text = $"所持金: {wCurrentMoney}円";
            this.BetNumericUpDown.Maximum = wCurrentMoney;
        }

        /// <summary>
        /// 賭け金の値が変更されたときに呼び出されるイベントハンドラ
        /// </summary>
        private void BetNumericUpDown_ValueChanged(object sender, EventArgs e) {
            UpdatePayoutLabel();
        }

        /// <summary>
        /// 賭け金に応じた払戻金を表示する
        /// </summary>
        private void UpdatePayoutLabel() {
            int wBetAmount = (int)this.BetNumericUpDown.Value;
            int wPayout = BetCalculator.CalculatePayout(wBetAmount, this.FSelectedHorse.Odds);
            this.PayoutLabel.Text = $"払戻金:        {wPayout}円";
        }

        /// <summary>
        /// 掛け金入力画面から購入馬券表示画面へ遷移する
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e) {

            this.GoNextForm(new TicketForm(this.FGameManager));


            int wBetAmount = (int)this.BetNumericUpDown.Value;

            if (wBetAmount == 0) {
                MessageBox.Show("賭け金を入力してください！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.FGameManager.TryBuyTicket(this.FSelectedHorse, wBetAmount, out string wErrorMessage)) {
                MessageBox.Show(wErrorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var wNextForm = new TicketForm(this.FGameManager);
            this.Hide();
            wNextForm.ShowDialog();
            this.Close();

        }

        /// <summary>
        /// 掛け金入力画面から馬選択画面へ遷移する
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
