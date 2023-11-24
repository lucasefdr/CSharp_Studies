Console.WriteLine("Enter a key");
Console.ReadKey();

await WaitAsync(5);

Console.WriteLine("Exit!");
Console.ReadKey();


async Task WaitAsync(int seconds)
{
    Console.WriteLine("Starting...");

    await Task.Delay(TimeSpan.FromSeconds(seconds));

    Console.WriteLine("Finishing...");
}