namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public class EletricCar : ICar
    {
        public Guid Id { get; set; }
        public int NumberOfTires { get; set; }
        public float BatterySize { get; set; }
    }
}