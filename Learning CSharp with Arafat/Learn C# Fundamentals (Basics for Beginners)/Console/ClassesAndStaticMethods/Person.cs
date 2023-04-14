using System;

namespace ClassesAndStaticMethods
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduction()
        {
            Console.WriteLine("My Name is {0} and I am {1} years old.", Name, Age);
        }
    }
}
