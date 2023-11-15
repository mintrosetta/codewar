namespace codewar
{
    public class TwoToOne
    {
        public static string Solve(string s1, string s2)
        {
            char[] temp = (s1 + s2).ToCharArray();
            
            Array.Sort(temp);
            
            string result = temp[0].ToString();
            char lastCharacter = temp[0];
            for (int index = 1; index < temp.Length; index++)
            {
                if (!temp[index].Equals(lastCharacter))
                {
                    result += temp[index];
                }

                lastCharacter = temp[index];
            }

            return result;
        }
    }
}

/*

    Best solution

    public static string Longest (string s1, string s2) 
    {
        return new string ((s1 +s2).Distinct().OrderBy(x=>x).ToArray ());
    }

*/