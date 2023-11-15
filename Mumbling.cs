 namespace codewar
{
    public class Mumbling
    {
        public static string Solve(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                string text = "";

                if (i != 0) text += "-";

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        text += s[i].ToString().ToUpper();
                    }
                    else 
                    {
                        text += s[i].ToString().ToLower();
                    }
                }

                result += text;
            }

            return result;
        }
    }
}

/*

    Best solution

    public static String Accum(string s) 
    {
        return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
    }

*/