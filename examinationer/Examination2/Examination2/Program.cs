/*
name: Luna carlin
class: TE22
info:
a program that calculates simple geometry of a rectangle/prism
*/
using System.Formats.Asn1;
using System.Xml.Linq;

while (true)
{
    float rectangle1 = 0;
    float rectangle2 = 0;
    //inputs booth rectangles sides
    while (true)
    {
        Console.WriteLine("Enter one rectangle side");
        try
        {
            rectangle1 = float.Parse(Console.ReadLine());
            break;
        }
        catch (Exception e)
        {
            Console.WriteLine("try again");
        }
    }
    while (true)
    {
        Console.WriteLine("Enter the other rectangle side");
        try
        {
            rectangle2 = float.Parse(Console.ReadLine());
            break;
        }
        catch (Exception e)
        {
            Console.WriteLine("try again");
        }
    }
    //checks if the rectangle is square
    if (rectangle1==rectangle2)
    {
        Console.WriteLine("Is square = true");
    }
    else 
    { 
        Console.WriteLine("Is square = false");
    }
    //multiplies the two sides of the rectangle to get the area and then prints it out
    float area = (rectangle1 * rectangle2);
    Console.WriteLine("rectangles sides are "+ rectangle1+" and "+rectangle2+" with a area of "+area);

    int volumeCalc = 0;
    while (true)
    {

        Console.WriteLine("how many volume calculations (1-10)");
        try
        {
            volumeCalc = int.Parse(Console.ReadLine());
            break;
        }
        catch (Exception e)
        {
            Console.WriteLine("try again");
        }
    }
    //makes so that "volumeCalc" cant be over 10 or under 1
    if (volumeCalc>10) { volumeCalc = 10; }
    else if (volumeCalc<1  ) { volumeCalc = 1; }
    

    
    Console.WriteLine("");
    Console.WriteLine("hight | volume");
    Console.WriteLine("--------------------");
    for (int i = 1; i < volumeCalc+1; i++)
    {
        //makes it so that the | is at the same place no mater how many character the variable has
        string space = "     ";
        if (i > 9) { space = "    "; }

        Console.WriteLine(i+space+"|" +area*i);
    }

    //stop script
    Console.WriteLine("# to stop");
    if (Console.ReadLine() == "#")
    {
        Environment.Exit(0);
    }
}