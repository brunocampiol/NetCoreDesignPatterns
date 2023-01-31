using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public class BoatFactory : Factory
    {
        public override IVehicle CreateVehicle()
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