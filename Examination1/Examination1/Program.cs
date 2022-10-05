


while(true)
{
    
    string Menu = Console.ReadLine();

    // meny för cirkelns matte
    if (Menu == "1")
    {
        Console.WriteLine("1: Calculate Area");
        Console.WriteLine("2: Calculate Circumference");
        Console.WriteLine("0: Back");
        Menu = Console.ReadLine();
        if (Menu == "1")
        {
            Console.Write("Input Radius: ");
            int Radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Area= "+(Radius*2*Math.PI));
        }
    }


}