using NetCoreDesignPatterns.Common.Extensions;

namespace NetCoreDesignPatterns.AbstractFactory
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    public static class Program
    {
        public static void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ClassicFurnitureFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ContemporaryFactory());
        }

        public static void ClientMethod(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var diningTable = factory.CreateDiningTable();

            Console.WriteLine(chair.ToJson());
            Console.WriteLine(diningTable.ToJson());
        }
    }
}