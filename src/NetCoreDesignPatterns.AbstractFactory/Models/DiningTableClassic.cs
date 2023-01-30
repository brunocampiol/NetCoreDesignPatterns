namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public class DiningTableClassic : IFurniture
    {
        public Guid Id { get; set; }
        public int Seats { get; set; }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        //public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        //{
        //    var result = collaborator.UsefulFunctionA();

        //    return $"The result of the B2 collaborating with the ({result})";
        //}
    }
}