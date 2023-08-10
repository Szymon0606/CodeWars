namespace Quadrants
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int QuadrantNumber = Quadrants(2, 3);
            Console.WriteLine(QuadrantNumber);
        }

        static int Quadrants(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}