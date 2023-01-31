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
            Console.WriteLine("Abstract Factory pattern");
            Console.WriteLine("");

            // The client code can work with any concrete factory class.
            Console.WriteLine("ClassicFurnitureFactory...");
            ClientMethod(new ClassicFurnitureFactory());
            Console.WriteLine();

            Console.WriteLine("ContemporaryFactory...");
            ClientMethod(new ContemporaryFactory());
        }

        public static void ClientMethod(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var diningTable = factory.CreateDiningTable();

            Console.WriteLine("Chair output:");
            Console.WriteLine(chair.ToJson());
            Console.WriteLine("Dinning table output:");
            Console.WriteLine(diningTable.ToJson());
        }
    }
}