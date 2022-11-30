int temperature = 20;
while (true)
{
    Console.WriteLine("Temperature: " + temperature);
    Console.WriteLine("# to turn off the AC");
    string answer = Console.ReadLine();

    if (answer == "#") { Environment.Exit(0); }

    Console.WriteLine("Insert temperature");
    temperature = int.Parse(Console.ReadLine());
    if (temperature > 25) { temperature = 20; }
    else if (temperature < 17) { temperature = 20; }

    


}