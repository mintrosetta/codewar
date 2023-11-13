namespace codewar
{
    public class ToCamelCase
    {
        public static string Solve(string str)
        {
            string[] words = str.Split(new char[] { '-', '_' });

            string result = "";
            for (int index = 0; index < words.Length; index++)
            {
                if (index == 0)
                {
                    result += words[index];
                }
                else
                {
                    string text = "";
                    for (int wordIndex = 1; wordIndex < words[index].Length; wordIndex++)
                    {
                        text += words[index][wordIndex];
                    }

                    result += (words[index][0].ToString().ToUpper() + text);
                }
            }

            return result;
        }
    }
}

/*

    :: Another Code

    public static string ToCamelCase(string str)
    {
        return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
    }

*/