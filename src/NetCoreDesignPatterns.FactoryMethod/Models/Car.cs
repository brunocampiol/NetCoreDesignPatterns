namespace NetCoreDesignPatterns.FactoryMethod.Models
{
    public class Car : IVehicle
    {
        public Guid Id { get ; set; }
        public int NumberOfTires { get; set; }
        public string Operation() => "Car Operation";
    }
}