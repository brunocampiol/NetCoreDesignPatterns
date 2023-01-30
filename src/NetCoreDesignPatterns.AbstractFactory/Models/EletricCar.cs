namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public class EletricCar : ICar
    {
        public Guid Id { get; set; }
        public int NumberOfTires { get; set; }
        public float BatterySize { get; set; }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        //public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        //{
        //    var result = collaborator.UsefulFunctionA();

        //    return $"The result of the B1 collaborating with the ({result})";
        //}
    }
}