using System;
using System.Collections.Generic;

namespace アプリ画面作成.Model {
    internal class Horse {
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
        private static readonly Random FRandom = new Random();
        // 馬の情報
        /// <summary>
        /// 馬番
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// 馬名
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// スピード
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// 運の良さ
        /// </summary>
        public int Luck { get; set; }
        /// <summary>
        /// オッズ
        /// </summary>
        public double Odds { get; set; }

        // レースの状態
        /// <summary>
        /// 現在位置
        /// </summary>
        public double Position { get; set; }
        /// <summary>
        /// ゴール済みかどうか
        /// </summary>
        public bool IsFinished { get; set; }
        /// <summary>
        /// 着順（ゴールした順番）
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// スピード補正
        /// </summary>
        public double SpeedCorrection { get; set; } = 1.0;

        public List<Trap> Traps { get; private set; } = new List<Trap>();

        // 算出
        /// <summary>
        /// 実効スピード = スピード × (1 + 運の良さ × 0.002)
        /// </summary>
        public double EffectiveSpeed {
            get { return this.Speed * ( 1 + this.Luck * 0.002 ); }
        }

        // <summary>
        /// レース状態をリセットする（新レース開始時用）
        /// </summary>
        public void ResetRaceState() {
            this.Position = 0;
            this.IsFinished = false;
            this.Rank = 0;
            this.SpeedCorrection = 1.0;
            this.Traps = Trap.GenerateTraps();
        }

        // コンストラクタ
        public static Horse Create(int vNumber, string vName) {
            return new Horse {
                Number = vNumber,
                Name = vName,
                Speed = FRandom.Next(1, 101),
                Luck = FRandom.Next(1, 101),
                Position = 0,
                IsFinished = false,
                Rank = 0,
                Traps = Trap.GenerateTraps()
            };
        }

        /// <summary>
        /// 馬名候補リストからランダムに重複なく名前を取得する
        /// </summary>
        /// <param name="vCount"></param>
        /// <returns>馬名リスト</returns>
        public static List<string> GetRandomNames(int vCount) {
            var wShuffledNameList = new List<string>(FHorseNameList);
            for (int i = wShuffledNameList.Count - 1 ; i > 0 ; i--) {
                int j = FRandom.Next(i + 1);
                string wTemp = wShuffledNameList[i];
                wShuffledNameList[i] = wShuffledNameList[j];
                wShuffledNameList[j] = wTemp;
            }
            return wShuffledNameList.GetRange(0, vCount);
        }

        /// <summary>
        /// 馬を移動させる
        /// </summary>
        /// <param name="vDistance"></param>
        public void Move(double vDistance) {

            if (this.IsFinished) return;

            this.Position += vDistance;

            if (this.Position >= GameState.C_CourseDistance) {
                this.Position = GameState.C_CourseDistance;
                this.IsFinished = true;
            }
        }
    }
}
