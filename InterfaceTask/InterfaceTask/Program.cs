using InterfaceTask.Models;

namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(54, 23, 3, "Diesel", 4, 16);
            Console.WriteLine(car.AverageSpeed());

        }
    }
}