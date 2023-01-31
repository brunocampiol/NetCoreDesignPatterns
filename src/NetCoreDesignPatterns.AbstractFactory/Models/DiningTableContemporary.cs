namespace NetCoreDesignPatterns.AbstractFactory.Models
{
    public class DiningTableContemporary : IFurniture
    {
        public Guid Id { get; set; }
        public int Seats { get; set; }
        public string Style => "Contemporary";
    }
}