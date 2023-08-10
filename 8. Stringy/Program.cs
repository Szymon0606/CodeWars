namespace Stringy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string BinaryCode = stringy(89);
            Console.WriteLine(BinaryCode);
        }

        public static string stringy(int size)
        {
            char[] result = new char[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = i % 2 == 0 ? '1' : '0';
            }
            return new string(result);
        }
    }
}