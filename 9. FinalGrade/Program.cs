namespace StudentsGrades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int FinalGrade = Grades(50, 5);
            Console.WriteLine("final grade is " + FinalGrade);
        }

        public static int Grades(int exam, int projects)
        {
            if (exam > 90 || projects > 10)
            {
                return 100;
            }
            else if (exam > 75 && projects >= 5)
            {
                return 90;
            }
            else if (exam > 50 && projects >= 2)
            {
                return 75;
            }
            else
            {
                return 0;
            }
        }
    }
}
