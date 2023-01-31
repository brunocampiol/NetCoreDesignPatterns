using NetCoreDesignPatterns.SimpleFactory.Models;

namespace NetCoreDesignPatterns.SimpleFactory
{
    // The Simple factory pattern  describes a class that has one creation method
    // with a large conditional that based on method parameters chooses which
    // product class to instantiate and then return.
    // In most cases, a simple factory is an intermediate step of introducing
    // Factory Method or Abstract Factory patterns.
    // A simple factory is usually represented by a single method in a single
    // class. Over time, this method might become too big, so you may decide
    // to extract parts of the method to subclasses. Once you do it several
    // times, you might discover that the whole thing turned into the
    // classic factory method pattern.
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