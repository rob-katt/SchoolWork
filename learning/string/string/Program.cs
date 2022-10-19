


while (true)
{
    string Name = Console.ReadLine();
    string piratename = "";
    for (int i = 0; i < Name.Length; i++)
    {
        char Check = Name[i];

        if ((Check == 'a' || Check == 'e' || Check == 'i' || Check == 'o' || Check == 'u' || Check == 'å' || Check == 'ä' || Check == 'ö' || Check == ' ') == false)
        {
            piratename = (Name[i] + "o" + Name[i]);


        }
        else
        {
            piratename = Name.ToString()[i] + "";
        }

        Console.Write(piratename);
        
    }
    Console.WriteLine();
    Console.WriteLine();
}