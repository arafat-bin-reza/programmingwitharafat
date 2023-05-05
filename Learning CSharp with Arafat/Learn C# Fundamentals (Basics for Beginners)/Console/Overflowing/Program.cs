using System;

namespace Overflowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte number = 255;
                number = number + 1;
            }
        }
    }
}
