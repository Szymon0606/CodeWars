namespace Quadrants
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string NumberOfSheeps = Sheeps(5);
            Console.WriteLine(NumberOfSheeps);
        }

        public static string Sheeps(int n)
        {
            string sheep = "";

            for (int i = 1; i <= n; i++)
            {
                sheep += $"{i} sheep...";
            }
            return sheep;
        }
    }
}