using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 20;
            var c = 30;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.WriteLine(a / c);
            Console.WriteLine(a % c);

            Console.WriteLine((float)a / (float)c);

            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);

            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            Console.WriteLine(c > a && c > b);
            Console.WriteLine(c > a && c == b);

            Console.WriteLine(c > a || c == b);
            Console.WriteLine(!(c > a || c == b));

        }
    }
}
