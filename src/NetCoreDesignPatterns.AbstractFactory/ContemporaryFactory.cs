using NetCoreDesignPatterns.AbstractFactory.Models;

namespace NetCoreDesignPatterns.AbstractFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class ContemporaryFactory : IFurnitureFactory
    {
        public IFurniture CreateChair()
        {
            return new ChairContemporary();
        }

        public IFurniture CreateDiningTable()
        {
            return new DiningTableContemporary();
        }
    }
}