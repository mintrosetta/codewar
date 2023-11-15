

namespace codewar
{
    public class CountingDuplicate
    {

        public static int Solve(string str)
        {
            char[] characters = str.ToLower().ToCharArray();

            if (characters.Length <= 0) return 0;

            Array.Sort(characters);

            int duplicateCount = 0;
            char lastCharacter = characters[0];
            bool isCounting = false;

            for (int index = 1; index < characters.Length; index++)
            {
                char character = characters[index];

                if (character.Equals(lastCharacter) && isCounting == false)
                {
                    duplicateCount++;
                    isCounting = true;
                }
                else if (!character.Equals(lastCharacter) && isCounting == true)
                {
                    isCounting = false;
                }

                lastCharacter = character;
            }

            return duplicateCount;
        }
    }
}

/*

    Best solution

    public static int DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
    }

*/