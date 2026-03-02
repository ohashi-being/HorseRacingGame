using System;
using System.Collections.Generic;

namespace PocketDerby.Model {
    /// <summary>
    /// 馬名マスタクラス
    /// </summary>
    internal class HorseNameMaster {
        /// <summary>
        /// 馬名候補リスト
        /// </summary>
        private static readonly List<string> FHorseNameList = new List<string> {
            "アトノマツリ", "イナズマ", "ウィルソン", "エンプレス", "オカネノニオイ",
            "ガイアフォース", "カミカゼ", "ギガタンク", "キョウモアリガト", "クイーンローズ",
            "グレートタワー", "ケンコウダイイチ", "ゴールドシップ", "コンヤモサケ", "サンデーマイニチ",
            "ジショウテンサイ", "シランケド", "ストロング", "セントビンセント", "ソニックブーム",
            "ダイフク", "チカラノカギリ", "ツー", "ドリームジャンボ", "ナンデヤネン",
            "ニゲキリタイ", "ヌルスルタン", "ネムイヨマダ", "ノーブル", "バッファロー",
            "ハヤテ", "ヒノトリ", "フォーチュン", "プラチナム", "ヘビーメタル",
            "ポテチ", "マグレ", "ミラクルスター", "ムラサキシキブ", "メノオクニアル",
            "モグモグタイム", "ヤケクソ", "ユウゲンジッコウ", "ヨコツナ", "ラッキーセブン",
            "リイゼン", "ルビーアイ", "レースクイーン", "ロイヤルブルー", "ワンチャン"
        };

        /// <summary>
        /// 馬名候補リストからランダムに重複なく名前を取得する
        /// </summary>
        /// <param name="vCount">取得する馬名の数※今回の実装では5が入る</param>
        /// <returns>馬名リスト</returns>
        public static List<string> GetRandomNames(int vCount) {
            var wRandom = new Random();
            var wShuffledNameList = new List<string>(FHorseNameList);
            for (int i = wShuffledNameList.Count - 1 ; i > 0 ; i--) {
                int j = wRandom.Next(i + 1);
                string wSwapName = wShuffledNameList[i];
                wShuffledNameList[i] = wShuffledNameList[j];
                wShuffledNameList[j] = wSwapName;
            }
            return wShuffledNameList.GetRange(0, vCount);
        }
    }
}
