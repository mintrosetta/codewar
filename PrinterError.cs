namespace codewar
{
    public class PrinterError
    {
        public static string Solve(string str)
        {
            int errorCount = 0;

            foreach (char c in str)
            {
                if (c < 'a' || c > 'm')
                {
                    errorCount++;
                }
            }

            return $"{errorCount}/{str.Length}";
        }
    }
}

/*
    Best solution

    public static string PrinterError(string s) 
    {
        return s.Where(c => c > 'm').Count() + "/" + s.Length;
    }
*/