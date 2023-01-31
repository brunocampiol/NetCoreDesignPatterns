using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}