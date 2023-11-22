namespace codewar
{
    public class StopGninnipsMySdrow
    {
        public static string Solve(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    string temp = "";
                    for (int wordIndex = words[i].Length - 1; wordIndex >= 0; wordIndex--)
                    {
                        temp += words[i][wordIndex];
                    }

                    words[i] = temp;
                }
            }

            return string.Join(' ', words);
        }
    }
}

/*

    Best solution

    public static string SpinWords(string sentence)
    {
        return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
    }

*/