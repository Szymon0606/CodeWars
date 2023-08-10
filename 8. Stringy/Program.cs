public class Kata
{
    public static string Stringy(int size)
    {
        char[] result = new char[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = i % 2 == 0 ? '1' : '0';
        }

        return new string(result);

    }
}