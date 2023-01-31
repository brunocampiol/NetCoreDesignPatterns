using NetCoreDesignPatterns.SimpleFactory.Models;

namespace NetCoreDesignPatterns.SimpleFactory
{
    public class UserFactory
    {
        public static IUser CreateUser(string type)
        {
            switch (type)
            {
                case "developer":                    
                    return new Developer();
                case "manager":
                    return new Manager();
                case "director":
                    return new Director();
                default:
                    throw new InvalidOperationException($"User type '{type}' is invalid");
            }
        }
    }
}