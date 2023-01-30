namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    // Each distinct product of a product family should have a base interface.
    // All variants of the product must implement this interface.
    public interface IBoat : IVehicle
    {
        public int Lenght { get; set; }
    }
}