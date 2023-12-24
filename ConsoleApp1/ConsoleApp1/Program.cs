// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = typeof(Program).Namespace ?? "None"!;
Console.WriteLine($"Namespace: {name}");
Console.WriteLine(Environment.CurrentDirectory);
Console.WriteLine(Environment.OSVersion.VersionString);
Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
throw new Exception();