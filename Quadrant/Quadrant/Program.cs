namespace Quadrant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
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