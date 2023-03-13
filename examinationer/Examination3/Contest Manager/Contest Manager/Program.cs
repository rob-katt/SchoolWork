using System.Runtime.CompilerServices;

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




Console.WriteLine("---------------------------------------------");
Console.WriteLine("| Gliding Point Calculator");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("| 1: Read");
Console.WriteLine("| 2: calculate");
Console.WriteLine("| 3: show");
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


string FileTemp;
FileTemp = File.ReadAllText("C:\\Temp\\Temp.txt");


/*

while(true)
{
    string FileTemp = "";
    try
    {
        string tempLine = "";
        FileTemp = File.ReadAllText("C:\\Temp\\Temp.txt");
       

        using (StreamReader sr = new StreamReader("C:\\Temp\\Temp.txt"))
        {
            int NumberOfLines = 0;
            
            List<string> lines = new List<string>();
            
            while ((tempLine = sr.ReadLine()) != null)
            {
                lines.Add(tempLine);
                NumberOfLines++;
                if (sr.Peek == null)
            {
                Console.WriteLine("end");
            }
            }
            int i = 0;
            foreach (string line in lines)
            {
                if (i < (NumberOfLines-1))
                {
                    Console.WriteLine(line);

                }
                else
                {
                    Console.Write(line);
                    
                }
                i++;

            }
            
            
        }
       
    }
    catch
    {
    
    }
   
    

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


*/