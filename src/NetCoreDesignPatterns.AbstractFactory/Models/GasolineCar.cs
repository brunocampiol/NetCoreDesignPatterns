namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public class GasolineCar : ICar
    {
        public Guid Id { get; set; }
        public int NumberOfTires { get; set; }
        public float FuelTankSize { get; set; }
    }
}