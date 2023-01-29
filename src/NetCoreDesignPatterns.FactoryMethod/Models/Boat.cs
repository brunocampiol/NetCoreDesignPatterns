namespace NetCoreDesignPatterns.FactoryMethod.Models
{
    public class Boat : IVehicle
    {
        public Guid Id { get; set; }
        public int Lenght { get; set; }
        public string Operation() => "Boat Operation";
    }
}