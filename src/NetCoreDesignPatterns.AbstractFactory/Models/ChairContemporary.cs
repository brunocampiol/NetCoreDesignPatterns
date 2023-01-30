namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ChairContemporary : IFurniture
    {
        public Guid Id { get; set; }
        public int MaxWeight { get; set; }
    }
}