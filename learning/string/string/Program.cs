
/*
while (true)
{
    string Name = Console.ReadLine();
    string PirateName = "";
    for (int i = 0; i < Name.Length; i++)
    {
        char Check = Name[i];

        if ((Check == 'a' || Check == 'e' || Check == 'i' || Check == 'o' || Check == 'u' || Check == 'å' || Check == 'ä' || Check == 'ö' || Check == ' ') == false)
        {
            PirateName = (Name[i] + "o" + Name[i]);


        }
        else
        {
            PirateName = Name.ToString()[i] + "";
        }

        Console.Write(PirateName);
        
    }
    Console.WriteLine();
    Console.WriteLine();
}
*/
using System.Data.SqlTypes;

while (true)
{
    string Name = Console.ReadLine();
    string normalName = "";

    for (int i = 0; i < Name.Length; i++)
    {
        
        if  (Name.Substring(i, i+2) == (Name[i] + "o"+ Name[i])) {
            Console.WriteLine(Name);

        }
        Console.WriteLine(normalName);
    }
}