namespace SameCase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int CheckSameCase = SameCase('a', 'b');
            Console.WriteLine(CheckSameCase);
        }

        public static int SameCase(char char1, char char2)
        {
            if (!char.IsLetter(char1) || !char.IsLetter(char2))
            {
                return -1;
            }
            else if (char.IsUpper(char1) == char.IsUpper(char2))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}