namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class CatamaranBoat : IBoat
    {
        public Guid Id { get; set; }
        public int Lenght { get; set; }
        public int NumberOfHulls { get; set; }
    }
}