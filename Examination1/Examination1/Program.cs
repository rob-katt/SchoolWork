
string Menu = "";
string SubMenu = "";
while (true)
{
    Console.Clear();
    Console.WriteLine("1: Circle");
    Console.WriteLine("2: Trigonometry");
    Console.WriteLine("3: Temperature");
    Console.WriteLine("0: exit");
    Menu = Console.ReadLine();
    switch (Menu)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("1: Calculate Area");
            Console.WriteLine("2: Calculate Circumference");
            Console.WriteLine("0: Back");
            SubMenu = Console.ReadLine();
            
            switch (SubMenu)
            {
                // meny för att räkna ut Arean med radien
                case "1":
                    Console.Clear();
                    Console.Write("Input Radius: ");
                    int Radius = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area = " + (Math.Pow(Radius, 2) * Math.PI));
                    Console.ReadKey();
                    break;
                // meny för att räkna ut Omkrets med diametern
                case "2":
                    Console.Clear();
                    Console.Write("Input Diameter: ");
                    int Diameter = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area = " + (Diameter * Math.PI));
                    Console.ReadKey();
                    break;
               

            }
            break;
        case "2":
            //triogemtri
            Console.Clear();
            Console.WriteLine("1: Calculate Hypotenuse");
            Console.WriteLine("2: Calculate Sine");
            Console.WriteLine("3: Calculate Cosine");
            Console.WriteLine("0: Back");
            SubMenu = Console.ReadLine();
            
            switch (SubMenu)
            {

                //petaguras sats
                case "1":
                    Console.Clear();
                    Console.Write("Input Cathetus 1: ");
                    int Cat1 = int.Parse(Console.ReadLine());
                    Console.Write("Input Cathetus 2: ");
                    int Cat2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hypotenuse = " + Math.Sqrt(Math.Pow(Cat1,2)+ Math.Pow(Cat2, 2)));
                    Console.ReadKey();
                    break;
                case "2":
                    //sinus
                    Console.Clear();
                    Console.Write("Input Number: ");
                    int sin = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sine = " + Math.Sin(sin));
                    Console.ReadKey();
                    break;
                case "3":
                    //cosinus
                    Console.Clear();
                    Console.Write("Input Number: ");
                    int Cos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sine = " + Math.Cos(Cos));
                    Console.ReadKey();
                    break;
            } 
            break;
        case "3":
            //temperature
            Console.Clear();
            double temp2Out = 0;
            Console.WriteLine("Select what to convert (c,f,k)");
            string temp1 = Console.ReadLine();
            Console.WriteLine("Select what to convert to (c,f,k)");
            string temp2 = Console.ReadLine();
            Console.WriteLine("");
            double temp1In = double.Parse(Console.ReadLine());
            double temp1Out = temp1In;
            switch (temp1.ToLower())
            {
               //converts the inputed temperature to celcius
                   
                case "f":
                    temp1Out = (temp1In - 32) * 5 / 9;
                    break;
                case "k":
                    temp1Out = temp1In-273.15;
                    break;

            }
            switch (temp2.ToLower())
            {
                //converts celcius into the selcted temperature
                case "c":
                    temp2Out = temp1Out;
                    break;
                case "f":
                    temp2Out = (temp1Out * 9 / 5) + 32;
                    break;
                case "k":
                    temp2Out = temp1Out + 273.15;
                    break;
            }
            
            Console.WriteLine(temp2+": "+ temp2Out);
            Console.ReadKey();
            break;


        case "0":
            //exit
            Environment.Exit(0);
            break;
        default:
            Console.Write("Please enter a valid input");
            Console.ReadKey();
            break;
    }
}