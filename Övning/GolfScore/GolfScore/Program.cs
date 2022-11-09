using System;
using System.Reflection.Metadata;

Dictionary<string,int> players = new Dictionary<string,int>();

while (true)
{
    Console.WriteLine("1: add player");
    Console.WriteLine("2: list players");
    string menu = Console.ReadLine();

    bool menu1 = false;
    switch (menu){
        case "1":
            {
                Console.WriteLine("playern name:");
                string player = Console.ReadLine();
                Console.WriteLine("Player handicap");
                int handicap = int.Parse(Console.ReadLine());
                if (handicap > 52)
                {
                    handicap = 52;
                }
                players.Add(player, handicap);
                break;
            }
        case "2":
            {
                foreach(KeyValuePair<string,int> kvp in players)
                {
                    Console.WriteLine(kvp.Key+ " (" + kvp.Value+")");
                }
                    break;
            }
        case "3":
            {
                string search = Console.ReadLine();
                foreach (KeyValuePair<string, int> kvp in players)
                {
                    if (kvp.Key.ToLower().Contains(search.ToLower()))
                    {
                        Console.WriteLine(kvp.Key + " (" + kvp.Value + ")");
                    }
                    
                }
                break;
            }
        case "4":
            {

                break;
            }
        case "0":
            {
                Environment.Exit(69);
                break;
            }
    }
        
  
}
