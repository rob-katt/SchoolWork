static double points(int D, int T ,int K)
{
    double V = D / T;
    double Dh = (D / K) * 100;
    double Vh = (V / K) * 100;
    double point = Dh + Vh;
    return point;
}
static void cParamiters()
{

}

int Distance = 50;
int Time = 5;
int koeficient = 100;

/*
while (true)
{
    if (Console.ReadKey().Key == ConsoleKey.Enter) { Console.WriteLine("gay :D"); }

}
*/

/*
Console.WriteLine("---------------------------------------------");
Console.WriteLine("| Gliding Point Calculator");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("| 1: Change competition paramiters");
Console.WriteLine("| 2: Per day calculator");
Console.WriteLine("| 0: exit");
Console.WriteLine("---------------------------------------------");
string menu = Console.ReadLine();



switch (menu) {
    case "1":
        {
            cParamiters();
            break;
        }
    case "2":
        {

            break;
        }
    case "3":
        {

            break;
        }
}
*/





while(true)
{
    string FileTemp = File.ReadAllText("C:\\Temp\\Temp.txt");
    Console.Write(FileTemp);

    ConsoleKeyInfo cki;
    cki = Console.ReadKey();
    string FileAdd = Convert.ToString(cki.KeyChar);
    if (cki.Key == ConsoleKey.Backspace)
    {
        using (StreamWriter sw = File.CreateText("C:\\Temp\\Temp.txt"))
        {
            if (FileTemp.Length != 0)
            {
                sw.Write(FileTemp.Remove(FileTemp.Length - 1));
            }
           
        }
    } 
    else
    {
        using (StreamWriter sw = File.CreateText("C:\\Temp\\Temp.txt"))
        {
            sw.Write(FileTemp + FileAdd);
        }
    }
      


    Console.Clear();
}


