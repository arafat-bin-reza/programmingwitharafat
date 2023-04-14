namespace ClassesAndStaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Arafat = new Person();
            Arafat.Name = "Arafat Bin Reza";
            Arafat.Age = 25;
            Arafat.Introduction();

            var result = Calculator.Add(1,2); // We do not need to create an object of a class to call static methods.
            System.Console.WriteLine(result);
        }
    }
}
