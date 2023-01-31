using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public class CarFactory : Factory
    {
        public override IVehicle CreateVehicle()
        {
            var car = new Car()
            {
                Id = Guid.NewGuid(),
                NumberOfTires = 4
            };

            return car;
        }
    }
}