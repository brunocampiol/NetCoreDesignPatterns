namespace NetCoreDesignPatterns.SimpleFactory.Models
{
    public class Manager : IUser
    {
        public Guid Id { get; set; }
        public int DirectReportsCount { get; set; }
    }
}