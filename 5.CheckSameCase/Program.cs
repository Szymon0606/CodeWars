class Program
{
    static int CheckSameCase(char char1, char char2)
    {
        if (!char.IsLetter(char1) || !char.IsLetter(char2))
        {
            // If either character is not a letter, return -1
            return -1;
        }
        else if (char.IsUpper(char1) == char.IsUpper(char2))
        {
            // If both characters are the same case, return 1
            return 1;
        }
        else
        {
            // If both characters are letters but not the same case, return 0
            return 0;
        }
    }
}