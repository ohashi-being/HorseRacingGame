using System;
using System.Drawing;
using System.Windows.Forms;
using PocketDerby.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    /// <summary>
    /// 馬選択画面クラス
    /// </summary>
    internal partial class HorseSelectForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private readonly GameManager FGameManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManagerインスタンス</param>
        internal HorseSelectForm(GameManager vGameManager) {
            InitializeComponent();
            this.FGameManager = vGameManager;

            SetupHorseImageList();
        }

        /// <summary>
        /// 馬の画像をImageListに読み込む設定を行う
        /// </summary>
        private void SetupHorseImageList() {
            for (int i = 1 ; i <= RaceRegulation.C_HorseCount ; i++) {
                string wKey = $"Horse{i}";
                var wImage = (Image)Properties.Resources.ResourceManager.GetObject(wKey);
                this.FHorseImageList.Images.Add(wKey, wImage);
            }
        }

        /// <summary>
        /// 馬選択画面から掛け金入力画面へ遷移する
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e) {

            if (this.ListView.SelectedItems.Count == 0) {
                MessageBox.Show("賭ける馬を1頭選択してください！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var wSelectedHorse = (Horse)this.ListView.SelectedItems[0].Tag;

            using (var wBetForm = new BetForm(this.FGameManager, wSelectedHorse)) {
                this.Hide();
                wBetForm.ShowDialog();

                if (wBetForm.DialogResult == DialogResult.OK) {
                    this.DialogResult = DialogResult.OK;
                    this.GoNextForm(new TicketForm(this.FGameManager));
                    return;
                }
            }
            this.Show();
            UpdateMoneyLabel();
        }

        /// <summary>
        /// フォームがロードされたときに呼び出されるイベントハンドラ
        /// </summary>
        private void HorseSelectForm_Load(object sender, EventArgs e) {

            this.FGameManager.SetupNewRace(RaceRegulation.C_HorseCount);

            UpdateMoneyLabel();
            SetupHorseList();
        }

        /// <summary>
        /// 現在の出走馬情報をリストビューに表示する
        /// </summary>
        private void SetupHorseList() {
            this.ListView.Items.Clear();

            foreach (var wHorse in this.FGameManager.CurrentHorses) {
                var wItem = CreateHorseListItem(wHorse);
                this.ListView.Items.Add(wItem);
            }
        }

        /// <summary>
        /// リストビューの1行を作成する
        /// </summary>
        /// <param name="vHorse">馬の情報</param>
        /// <returns>リストビューの1行分</returns>
        private ListViewItem CreateHorseListItem(Horse vHorse) {
            var wItem = new ListViewItem("", $"Horse{vHorse.Number}");
            wItem.SubItems.Add(DisplayHelper.GetCircleNumber(vHorse.Number));
            wItem.SubItems.Add(vHorse.Name);
            wItem.SubItems.Add(vHorse.Speed.ToString());
            wItem.SubItems.Add(vHorse.Luck.ToString());
            wItem.SubItems.Add(vHorse.Odds.ToString("F1"));
            wItem.Tag = vHorse;

            return wItem;
        }

        /// <summary>
        /// 所持金表示を更新する
        /// </summary>
        private void UpdateMoneyLabel() {
            this.CurrentMoneyLabel.Text = $"所持金：{this.FGameManager.PlayerMoney.Money}円";
        }

        /// <summary>
        /// フォームが閉じられるときに呼び出されるイベントハンドラ
        /// </summary>
        private void HorseSelectForm_FormClosed(object sender, FormClosedEventArgs e) {
            if (this.DialogResult != DialogResult.OK) Application.Exit();
        }
    }
}
