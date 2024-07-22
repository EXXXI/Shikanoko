using System.Text;

namespace Shikanoko
{
    // エントリポイント
    class Program
    {
        // 指定がない場合の最大値
        const int DefaultCap = 10000;

        // 正解
        const string Collect = "しかのこのこのここしたんたん";

        static void Main(string[] args)
        {
            // 引数から最大値を取得
            if (args.Length < 1 || !int.TryParse(args[0], out int cap))
            {
                cap = DefaultCap;
            }

            // 本体部
            StringBuilder sb = new();
            Word word = Word.し;
            for (int i = 0; i < cap; i++)
            {
                // 1文字StringBuilderに追加
                sb.Append(word.Word2Char());

                // 末尾がしかのこのこのここしたんたんだったら終了
                if (sb.ToString(Math.Max(sb.Length - Collect.Length, 0), Math.Min(Collect.Length, sb.Length)).Equals(Collect))
                {
                    break;
                }

                // 次の文字を生成
                word = word.NextWord();
            }

            // 出力
            string str = sb.ToString();
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.ReadKey();
            return;
        }

    }
}