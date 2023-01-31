using NetCoreDesignPatterns.AbstractFactory.Models;

namespace NetCoreDesignPatterns.AbstractFactory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateChair()
        {
            return new ChairClassic();
        }

        public IFurniture CreateDiningTable()
        {
            return new DiningTableClassic();
        }
    }
}