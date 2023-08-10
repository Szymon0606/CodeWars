public static class Kata 
{
    public static string Main(string name)
    {
        return "Hello, " + name + "!";
        if (name == "Johnny")
            return "Hello, my love!";
    }
}
// moje 

public static class Kata2
{
    public static string Main(string name)
    {
        if (name == "Johnny")
        {
            return "Hello, my love!";
        }
        else
        {
            return $"Hello,{name} !";
        }
    }
}