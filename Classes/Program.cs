namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "RAV4";
            myCar.Year = 2017;
            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
        }
    }
}
