// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello, World! From {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");

if (args.Length > 0)
{
    int iterator = 0;
    foreach (var arg in args)
    {
        iterator++;
        Console.WriteLine($"Argument{iterator}={arg}");
    }
}

else
{
    Console.Write("No Arguments passed.");
}

// public 