using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public abstract class Factory
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract IVehicle CreateVehicle();

    }
}