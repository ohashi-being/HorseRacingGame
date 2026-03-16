using System.Windows.Forms;

namespace PocketDerby {
    /// <summary>
    /// 画面遷移を管理するクラス
    /// </summary>
    internal static class FormTransition {

        /// <summary>
        /// 次の画面へ遷移する
        /// </summary>
        /// <param name="vCurrentForm">現在表示中のフォーム</param>
        /// <param name="vNextForm">次に表示するフォーム</param>
        public static void GoNextForm(this Form vCurrentForm, Form vNextForm) {
            vCurrentForm.Hide();
            vNextForm.ShowDialog();
            vCurrentForm.Close();
        }
    }
}