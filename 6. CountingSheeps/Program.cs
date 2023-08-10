using System;

public static class Kata
{
    public static string CountSheep(int n)
    {
        string sheep = "";
        for (int i = 1; i <= n; i++)
        {
            sheep += $"{i} sheep...";

        }
        return sheep;

    }
}