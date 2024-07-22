namespace Shikanoko
{
    // 各文字を表す列挙型
    internal enum Word
    {
        し,
        か,
        の,
        こ,
        た,
        ん,
        〇
    }

    // 拡張メソッド用クラス
    static class WordExtensions
    {
        // 乱数
        static readonly Random Rand = new();

        // 列挙型を文字に
        internal static char Word2Char(this Word word)
        {
            switch (word)
            {
                case Word.し:
                    return 'し';
                case Word.か:
                    return 'か';
                case Word.の:
                    return 'の';
                case Word.こ:
                    return 'こ';
                case Word.た:
                    return 'た';
                case Word.ん:
                    return 'ん';
                case Word.〇:
                    return '・';
                default:
                    return '　';
            }
        }

        // ルールに従ってランダムに次の文字へ
        internal static Word NextWord(this Word word)
        {
            int rand = Rand.Next(0, 4);
            
            switch (word)
            {
                case Word.し:
                    if (rand < 2)
                    {
                        return Word.か;
                    }
                    else
                    {
                        return Word.た;
                    }
                case Word.か:
                    return Word.の;
                case Word.の:
                    return Word.こ;
                case Word.こ:
                    if (rand < 2)
                    {
                        return Word.の;
                    }
                    else if (rand < 3)
                    {
                        return Word.こ;
                    }
                    {
                        return Word.し;
                    }
                case Word.た:
                    return Word.ん;
                case Word.ん:
                    if (rand < 2)
                    {
                        return Word.た;
                    }
                    else
                    {
                        return Word.〇;
                    }
                case Word.〇:
                    if (rand < 2)
                    {
                        return Word.し;
                    }
                    else
                    {
                        return Word.〇;
                    }
                default:
                    return Word.し;
            }
        }
    }
}
