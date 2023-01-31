using NetCoreDesignPatterns.FactoryMethod.Models;

namespace NetCoreDesignPatterns.FactoryMethod
{
    // Note that the Factory may also provide some
    // default implementation of the factory method.
    public abstract class VehicleFactory : IVehicleFactory
    {
        public abstract IVehicle CreateVehicle();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = CreateVehicle();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }
}