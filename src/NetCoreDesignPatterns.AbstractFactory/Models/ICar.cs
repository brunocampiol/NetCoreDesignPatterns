namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    // Here's the the base interface of another product. All products can
    // interact with each other, but proper interaction is possible only between
    // products of the same concrete variant.
    public interface ICar : IVehicle
    {
        public int NumberOfTires { get; set; }

    }
}