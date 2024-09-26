namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            firstCar.make = "Nissan";
            firstCar.model = "Altima";
            firstCar.year = 1990;
            
            Console.WriteLine(firstCar.make);
            Console.WriteLine(firstCar.model);
            Console.WriteLine(firstCar.year);
        }
    }
}
