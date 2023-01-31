using NetCoreDesignPatterns.Common.Extensions;
using NetCoreDesignPatterns.SimpleFactory;

Console.WriteLine("Simple Factory pattern");
Console.WriteLine("");

Console.WriteLine("Developer user output:");
var developer = UserFactory.CreateUser("developer");
Console.WriteLine(developer.ToJson());

Console.WriteLine("Manager user output:");
var manager = UserFactory.CreateUser("manager");
Console.WriteLine(manager.ToJson());