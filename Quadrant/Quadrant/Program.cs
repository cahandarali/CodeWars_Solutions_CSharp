namespace Quadrant
{
    internal class Program
    {
        //Basic function which will look where x and y is placed and will return you in which quadrant you are now
        public static int Quadrant(int x, int y)
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
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            return 0;
        }
    }
}