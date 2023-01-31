namespace NetCoreDesignPatterns.SimpleFactory.Models
{
    public class Developer : IUser
    {
        public Guid Id { get; set; }
        public int YearsAsDeveloper { get; set; }
    }
}