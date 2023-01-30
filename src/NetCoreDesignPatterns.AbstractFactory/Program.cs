using NetCoreDesignPatterns.Common.Extensions;

namespace NetCoreDesignPatterns.AbstractFactory
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    internal class Program
    {
        public void Main(string[] args)
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new BoatFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new CarFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var boat = factory.CreateProductBoat();
            var car = factory.CreateVehicleCar();

            Console.WriteLine(boat.ToJson());
            Console.WriteLine(car.ToJson());
            //Console.WriteLine(productB.UsefulFunctionB());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}