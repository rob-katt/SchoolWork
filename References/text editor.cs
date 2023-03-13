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