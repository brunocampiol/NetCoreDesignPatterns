namespace NetCoreDesignPatterns.FactoryMethod.Models
{
    public interface IVehicle
    {
        public Guid Id { get; set; }
        public string Operation();
    }
}