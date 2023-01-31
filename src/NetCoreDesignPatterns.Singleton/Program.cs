using NetCoreDesignPatterns.Singleton;

var numberOfIterations = 25;

Console.WriteLine("Singleton");

Console.WriteLine("Parallel operations should not change singleton instance ID");
Console.WriteLine($"Running for '{numberOfIterations}' items");


ParallelOptions parallelOptions = new()
{
    MaxDegreeOfParallelism = numberOfIterations
};

Parallel.For(0, numberOfIterations, parallelOptions, index =>
{
    Console.WriteLine(Singleton.Instance.InstanceId);
});