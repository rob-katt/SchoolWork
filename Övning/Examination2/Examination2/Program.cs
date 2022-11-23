/*
name: Luna carlin
class: TE22
info:
a program
*/
using System.Formats.Asn1;
using System.Xml.Linq;

while (true)
{
    Console.WriteLine("Enter one rectangle side");
    float rectangle1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter the other rectangle side");
    float rectangle2 = float.Parse(Console.ReadLine());
    float area = (rectangle1 * rectangle2);
    if (rectangle1==rectangle2)
    {
        Console.WriteLine("Is square = true");
    }
    else 
    { 
        Console.WriteLine("Is square = false");
    }

    Console.WriteLine("rectangles sides are "+ rectangle1+" and "+rectangle2+" with a area of "+area);

    Console.WriteLine("input volume calculator");
    int volumeCalc = int.Parse(Console.ReadLine());
    if (volumeCalc>10) { volumeCalc = 10; }

    Console.WriteLine("");
    Console.WriteLine("hight | volume");
    Console.WriteLine("--------------------");
    for (int i = 1; i < volumeCalc+1; i++)
    {

        string space = "     ";
        if (i > 9) { space = "    "; }

        Console.WriteLine(i+space+"|" +area*i);
    }
}