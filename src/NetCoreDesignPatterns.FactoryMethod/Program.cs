using NetCoreDesignPatterns.Common.Extensions;
using NetCoreDesignPatterns.FactoryMethod;

Console.WriteLine("Factory Method pattern");
Console.WriteLine("");

Console.WriteLine("CarFactory output:");
var carCreator = new CarFactory();
var car = carCreator.CreateVehicle();
Console.WriteLine(car.ToJson());
Console.WriteLine(carCreator.SomeOperation());

Console.WriteLine("BoatFactory output:");
var boatCreator = new BoatFactory();
var boat = boatCreator.CreateVehicle();
Console.WriteLine(boat.ToJson());
Console.WriteLine(boatCreator.SomeOperation());