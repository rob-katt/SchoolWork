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
/*
ConsoleKeyInfo cki;


Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
Console.WriteLine("Press the Escape (Esc) key to quit: \n");
do
{
    cki = Console.ReadKey();
    Console.WriteLine(cki.KeyChar);
} while (cki.Key != ConsoleKey.Escape);

*/


using (StreamWriter sw = File.CreateText("Temp.txt"))
{
    sw.WriteLine("Name: ");
    sw.WriteLine("Mail: ");
    sw.WriteLine("Adress: ");
}
Console.ReadKey();
/*
string SaveInput = File.ReadAllText("Temp.txt");
using (StreamWriter sw = File.CreateText("Temp.txt"))
{
    sw.WriteLine(SaveInput.Trim());
    sw.WriteLine(SelectedFile.Trim());
}
*/