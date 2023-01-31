namespace NetCoreDesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }

        public Guid InstanceId { get; set; }

        private Singleton() 
        {
            InstanceId = Guid.NewGuid();
        }
    }
}