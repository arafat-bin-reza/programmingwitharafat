using System;

namespace Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //explicit conversion
            int i1 = 1;
            byte b1 = (byte) i1;
            Console.WriteLine(b);

            //Non-compatible type
            var number = "1234";
            //int i3 = (int) number;
            int i4 = Convert.ToInt32(number);
            Console.WriteLine(i4);

            try
            {
               var number1 = "1234";
               byte b2 = Convert.ToByte(number1);
               Console.WriteLine(b2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            var str = "True";
            var b3 = Convert.ToBoolean(str);
            Console.WriteLine(b3);
        }
    }
}
