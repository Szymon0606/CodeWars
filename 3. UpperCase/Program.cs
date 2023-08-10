namespace ChangeString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string AfterMethod = UpperCase(input);
            Console.WriteLine(AfterMethod);
        }

        public static string UpperCase(string input)
        {
            string UpperCaseString = input.ToUpper();
            return UpperCaseString;
        }
    }
}