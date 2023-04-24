namespace CheckSameCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int SameCase(char a, char b)
        {
            if (!char.IsLetter(a) || !char.IsLetter(b))
            {
                return -1;
            }
            else if ((char.IsLower(a) && char.IsLower(b)) || (!char.IsLower(a) && !char.IsLower(b)))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}