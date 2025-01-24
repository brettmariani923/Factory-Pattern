using System.Linq.Expressions;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires??");
            string input = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(input);
            vehicle.Drive();
        }
    }
}