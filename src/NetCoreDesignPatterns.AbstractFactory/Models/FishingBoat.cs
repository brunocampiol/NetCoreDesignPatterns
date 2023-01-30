namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class FishingBoat : IBoat
    {
        public Guid Id { get; set; }
        public int Lenght { get; set; }
        public float FishTankSize { get; set; }
    }
}