class Program
{
    static int GetQuadrant(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            // First quadrant
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            // Second quadrant
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            // Third quadrant
            return 3;
        }
        else
        {
            // Fourth quadrant
            return 4;
        }
    }
}