namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public interface ICar : IVehicle
    {
        public int NumberOfTires { get; set; }

    }
}