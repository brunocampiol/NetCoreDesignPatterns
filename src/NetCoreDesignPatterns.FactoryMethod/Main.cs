namespace NetCoreDesignPatterns.FactoryMethod
{
    public static class Main
    {
        public static void Example()
        {
            var carCreator = new CarCreator();
            var car = carCreator.FactoryMethod();            

            var boatCreator = new BoatCreator();
            var boat = boatCreator.FactoryMethod();
        }
    }
}