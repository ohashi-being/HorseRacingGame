using System;
using System.Drawing;
using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    /// <summary>
    /// 馬選択画面クラス
    /// </summary>
    internal partial class HorseSelectForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private GameManager FGameManager;

        /// <summary>
        /// 馬の画像を管理するImageList
        /// </summary>
        private readonly ImageList FHorseImageList = new ImageList();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManager">ゲーム全体を管理するGameManegerインスタンス</param>
        internal HorseSelectForm(GameManager vGameManager) {
            InitializeComponent();
            this.FGameManager = vGameManager;

            SetupListView();
            SetupHorseImageList();
        }

        /// <summary>
        /// リストビューの設定を行う
        /// </summary>
        private void SetupListView() {
            this.HorseImageColumn.Width = 120;
            this.HorseNumberColumn.Width = 70;
            this.HorseNameColumn.Width = 180;
            this.SpeedColumn.Width = 100;
            this.LuckColumn.Width = 120;
            this.OddsColumn.Width = 90;

            this.ListView.Font = new Font("HG創英角ポップ体", 18F, FontStyle.Regular);
        }

        /// <summary>
        /// 馬の画像をImageListに読み込む設定を行う
        /// </summary>
        private void SetupHorseImageList() {
            this.FHorseImageList.ImageSize = new Size(80, 58);
            this.FHorseImageList.ColorDepth = ColorDepth.Depth32Bit;
            this.FHorseImageList.Images.Add("Horse1", Properties.Resources.Horse1);
            this.FHorseImageList.Images.Add("Horse2", Properties.Resources.Horse2);
            this.FHorseImageList.Images.Add("Horse3", Properties.Resources.Horse3);
            this.FHorseImageList.Images.Add("Horse4", Properties.Resources.Horse4);
            this.FHorseImageList.Images.Add("Horse5", Properties.Resources.Horse5);

            this.ListView.SmallImageList = this.FHorseImageList;
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

            var wBetForm = new BetForm(this.FGameManager, wSelectedHorse);
            this.Hide();
            wBetForm.ShowDialog();

            this.Show();

            UpdateMoneyLabel();
        }

        /// <summary>
        /// 現在の出走馬情報をリストビューに表示する
        /// </summary>
        private void HorseSelectForm_Load(object sender, EventArgs e) {

            if (this.FGameManager.CurrentHorses == null || this.FGameManager.CurrentHorses.Count == 0) {
                this.FGameManager.SetupNewRace(5);
            }

            UpdateMoneyLabel();
            LoadHorseList();
        }

        /// <summary>
        /// 現在の出走馬情報をリストビューに表示する
        /// </summary>
        private void LoadHorseList() {
            this.ListView.Items.Clear();

            foreach (var wHorse in this.FGameManager.CurrentHorses) {
                var wItem = CreateHorseListItem(wHorse);
                this.ListView.Items.Add(wItem);
            }
        }

        /// <summary>
        ///リストビューの1行を作成する
        /// </summary>
        /// <param name="vHorse">馬の情報</param>
        /// <returns>リストビューの1行分</returns>
        private ListViewItem CreateHorseListItem(Horse vHorse) {
            var wItem = new ListViewItem("", $"Horse{vHorse.Number}");
            wItem.SubItems.Add(GetCircleNumber(vHorse.Number));
            wItem.SubItems.Add(vHorse.Name);
            wItem.SubItems.Add(vHorse.Speed.ToString());
            wItem.SubItems.Add(vHorse.Luck.ToString());
            wItem.SubItems.Add(vHorse.Odds.ToString("F1"));
            wItem.Tag = vHorse;

            return wItem;
        }

        /// <summary>
        /// 馬番を丸数字に変換する
        /// </summary>
        /// <param name="vNumber">馬番</param>
        /// <returns>丸数字の文字列</returns>
        public static string GetCircleNumber(int vNumber) {
            string[] wCircleNumber = { "①", "②", "③", "④", "⑤" };
            if (vNumber >= 1 && vNumber <= wCircleNumber.Length) {
                return wCircleNumber[vNumber - 1];
            }
            return vNumber.ToString();
        }

        /// <summary>
        /// 所持金表示を更新する
        /// </summary>
        private void UpdateMoneyLabel() {
            this.CurrentMoneyLabel.Text = $"所持金：{this.FGameManager.PlayerMoney.Money}円";
        }
    }
}
