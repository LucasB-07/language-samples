using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# Demo Line " + i);
            }

            int sum = Add(3, 4);
            Console.WriteLine("Sum: " + sum);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Extra line for C# " + i);
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}