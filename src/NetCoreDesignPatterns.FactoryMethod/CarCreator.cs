using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public class CarCreator : Creator
    {
        public override IVehicle FactoryMethod()
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