using System;

namespace Average
{
    class MainClass
    {
        public static double Average(int a, int b)
        {
            return (double)(a + b) / 2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
        }
    }
}
