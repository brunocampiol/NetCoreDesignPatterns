using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public class BoatCreator : Creator
    {
        public override IVehicle FactoryMethod()
        {
            var boat = new Boat()
            {
                Id = Guid.NewGuid(),
                Lenght = 100
            };

            return boat;
        }
    }
}