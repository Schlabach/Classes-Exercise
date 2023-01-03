namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var truck = new Car();
            truck.Year = "2015";
            truck.Make = "Chevy";
            truck.Model = "Silverado";

            Console.WriteLine($"{truck.Year} {truck.Make} {truck.Model}");
        }
    }
}
