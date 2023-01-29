namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public class Boat : IBoat
    {
        public Guid Id { get; set; }
        public int Lenght { get; set; }
    }
}