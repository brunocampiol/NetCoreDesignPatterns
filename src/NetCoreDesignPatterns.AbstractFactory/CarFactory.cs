using NetCoreDesignPatterns.AbstractFactory.Models;

namespace NetCoreDesignPatterns.AbstractFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class CarFactory : IAbstractFactory
    {
        public IBoat CreateProductBoat()
        {
            throw new NotImplementedException();
        }

        public ICar CreateVehicleCar()
        {
            throw new NotImplementedException();
        }
    }
}
