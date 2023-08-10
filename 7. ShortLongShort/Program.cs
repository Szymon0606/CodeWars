internal class Program
{
    static string Solution(string a, string b)
    {
        return a.Length > b.Length ? b + a + b : a + b + a;
    }

    static void Main(string[] args)
    {
        string input1 = "5";
        string input2 = "11";
        string result = Solution(input1, input2);
        Console.WriteLine(result);
    }
}
