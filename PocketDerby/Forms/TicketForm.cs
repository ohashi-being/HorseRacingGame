using System.Windows.Forms;
using PocketDerby.Model;

namespace PocketDerby {
    internal partial class TicketForm : Form {

        /// <summary>
        /// ゲーム全体を管理するGameManagerインスタンス
        /// </summary>
        private GameManager FGameManager;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vGameManeger">ゲーム全体を管理するGameManagerインスタンス</param>
        public TicketForm(GameManager vGameManeger) {
            InitializeComponent();

            this.FGameManager = vGameManeger;
        }
    }
}
