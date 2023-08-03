class Kata
{
    public static int TotalPoints(string[] matches)
    {
        int points = 0;
        foreach (string match in matches)
        {
            int x = int.Parse(match.Split(':')[0]);
            int y = int.Parse(match.Split(':')[1]);

            if (x > y)
            {
                points += 3;
            }
            else if (x == y)
            {
                points += 1;
            }
        }
        return points;
    }

    public static void Main()
    {
        string[] matches = { "3:2", "2:2", "4:1", "1:1", "0:3", "3:3", "2:1", "1:3", "3:2", "0:0" };
        int points = TotalPoints(matches);
        Console.WriteLine($"Total points:{points}");
    }
}