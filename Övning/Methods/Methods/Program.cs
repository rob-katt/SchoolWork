/*
//testing
 static int message(int number1, int number2)
{
    int sum = number1 * number2;
    return sum;
}

int test1= 5;
int number2= 5;

int sum = message(test1, number2);

Console.WriteLine(sum);
*/

/*
// test assignment 1
static string hello(string message)
{

    return message+" :)";
}

string message = Console.ReadLine();

Console.WriteLine(hello(message));
*/

/*
// test assignment 2

static string stringsum(string message1, string message2)
{
    return (message1+message2);
}
string message1 = Console.ReadLine();
string message2 = Console.ReadLine();

Console.WriteLine(stringsum(message1,message2));
*/



/*
// test assignment 3 
static int multiply(int number1,int number2)
{
    return number1 * number2;
}

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine(multiply(number1,number2));

*/



/*
// test assignment 4
static double vat(int price, double moms)
{
    return price * (moms/100 + 1);
}

int price = int.Parse(Console.ReadLine());
int moms = int.Parse(Console.ReadLine());
Console.WriteLine(vat(price,moms));
*/

/*
// test assignment 5

static float ToPercentage(float number)
{
    return number * 100;
}

float number = float.Parse(Console.ReadLine());

Console.WriteLine(ToPercentage(number));
*/

/*
// test assignment 6
static bool checkAge(int age)
{
    return age >= 18;
}

int age = int.Parse(Console.ReadLine());

Console.WriteLine(checkAge(age));
*/

/*
// test assignment 7
using System.Xml.Linq;

static int breakSentece(string sentence)
{
        return sentence.Length;

}

string sentence = Console.ReadLine();

Console.WriteLine(breakSentece(sentence));
*/

/*
//test assigment 8

static double cToF(int celcius)
{
    return(celcius * 9 / 5) + 32;
}
static double fToC(int fahrenheit)
{
    return(fahrenheit - 32) * 5 / 9;
}

Console.WriteLine("1: celcius fahrenheit");
Console.WriteLine("2: fahrenheit to celcius");
Console.WriteLine("0. exit");
while (true)
{
    string menu = Console.ReadLine();
    switch (menu)
    {
        case "1":
            {
                int celcius = int.Parse(Console.ReadLine());
                Console.WriteLine(cToF(celcius));
                break;
            }
        case "2":
            {
                int fahrenheit = int.Parse(Console.ReadLine());
                Console.WriteLine(fToC(fahrenheit));
                break;
            }
        case "0":
            {
                Environment.Exit(0);
                break;
            }
    }
}
*/

/*
//test assigment 9

using System.ComponentModel.Design;

static int addition(int number1,int number2)
{
    return number1 + number2;
}
static int subtaction(int number1,int number2)
{
    return number1 - number2;
}
static int multiplication(int number1,int number2)
{
    return number1 * number2;
}
static int division(int number1, int number2)
{
    return number1 / number2;
}
static double potencies(int number1, int number2)
{
    return  Math.Pow(number1,number2);
}
static double squareroot(int number1)
{
    return Math.Sqrt(number1);
}



while (true)
{
    Console.WriteLine("+: for addition");
    Console.WriteLine("-: for subtraction");
    Console.WriteLine("*: for multiplication");
    Console.WriteLine("/: for division");
    Console.WriteLine("^: for potencies");
    Console.WriteLine("sqrt: for square root");

    Console.WriteLine("Q: for exit");

    string menu = Console.ReadLine();
    Console.WriteLine("first input");
    int number2 = 0;
    int number1 = int.Parse(Console.ReadLine());
    if (menu != "sqrt" )
    {
        Console.WriteLine("second input");
         number2 = int.Parse(Console.ReadLine());
    }
  


    switch (menu)
    {
        case "+": 
            {
                Console.WriteLine(addition(number1,number2));
                break;
            }
        case"-":
            {
                Console.WriteLine(subtaction(number1,number2));
                break;
            }
        case "*":
            {
                Console.WriteLine(multiplication(number1,number2));
                break;
            }
        case "/":
            {
                Console.WriteLine(division(number1,number2));
                break;
            }
        case "^":
            {
                Console.WriteLine(potencies(number1,number2));
                break;
            }
        case "sqrt":
            {
                Console.WriteLine(squareroot(number1));
                break;
            }
        default:
            {
                Console.WriteLine("error");
                    break;
            }
    }
}
*/

//test assigment 10
