namespace codewar
{
    public class BreakCamelCase
    {
        public static string Solve(string str)
        {
            List<string> words = new List<string>();

            string wordTemp = "";
            foreach (char character in str)
            {
                if (character.Equals(Char.ToUpper(character)))
                {
                    if (!string.IsNullOrEmpty(wordTemp))
                    {
                        words.Add(wordTemp);
                    }
                    wordTemp = character.ToString();
                }
                else
                {
                    wordTemp += character;
                }
            }

            if (!string.IsNullOrEmpty(wordTemp))
            {
                words.Add(wordTemp);
            }

            return string.Join(" ", words);
        }
    }
}

/*

    Best Solution

    using System.Text.RegularExpressions;

    public class Kata
    {
        public static string BreakCamelCase(string str) => new Regex("([A-Z])").Replace(str, " $1");
    }

*/