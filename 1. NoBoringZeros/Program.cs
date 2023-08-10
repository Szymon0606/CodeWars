namespace ZerosAreBoring
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2020, 900010, 120, -20010 };

            foreach (int number in numbers)
            {
                int result = NoBoringZeros(number);
                Console.WriteLine($"{number}->{result}");
            }
        }

        public static int NoBoringZeros(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            while (number % 10 == 0)
            {
                number /= 10;
            }
            return number;
        }
    }
}
