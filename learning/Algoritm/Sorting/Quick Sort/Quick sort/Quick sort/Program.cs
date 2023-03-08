using System.Globalization;
/*
static void bubblesort(List<int> data)
{
    int sorts = 0;
    for (int i = 0; i < data.Count - 1; i++)
    {

        //pain
        for (int j = 0; j < data.Count - 1 - i; j++)
        {
            if (data[j] > data[j + 1])
            {
                int temp = data[j + 1];
                data[j + 1] = data[j];
                data[j] = temp;
                sorts++;
            }
        }
    }
    data.Add(sorts);
}
*/
static void quickSort(List<int> data)
{
    int start = 0;
    int end = data.Count-1;
    while (true)
    {
        int mid = (start+end)/2;

        for (int i = 0; i < data.Count - 1; i++)
        {
            if(i > mid)
            {
                int tmep = data[i];
                data[i] = data[];
            }
        }
    }
}
static void randomList(List<int> data)
{
    Random rnd = new Random();

    for (int i = 0; i < 99; i++)
    {
        data.Add(rnd.Next(1, 100));
    }
}

List<int> numbers = new List<int> { };
randomList(numbers);


Console.WriteLine("unsorted:");

for (int i = 0; i < numbers.Count; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
Console.WriteLine("sorted:");
bubblesort(numbers);
for (int i = 0; i < numbers.Count - 1; i++)
{
    Console.Write(numbers[i] + " ");

}
Console.WriteLine();

Console.WriteLine("number of sorts: ");
Console.WriteLine(numbers[numbers.Count - 1]);