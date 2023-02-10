using System.Globalization;

static void bubblesort(List<int> data)
{
    int sorts = 0;
    for (int i = 0; i < data.Count - 1; i++)
    {
        
        //pain
        for(int j =0 ; j <data.Count -1-i; j++)
        {
            if (data[j] > data[j+1]) 
            {
                int temp = data[j+1];
                data[j+1] = data[j];
                data[j] = temp;
                sorts++;
            }
        }
    }
    data.Add(sorts);
}

List<int> numbers = new List<int>{ 3, 4, 8, 3, 5, 8, 2,3,5,3,2,6 };

Console.WriteLine("unsorted:");

for (int i=0; i < numbers.Count; i++){
    Console.Write(numbers[i]+ " ");
}
Console.WriteLine();
Console.WriteLine("sorted:");
bubblesort(numbers);
for (int i = 0; i < numbers.Count-1; i++)
{
    Console.Write(numbers[i] + " ");
    
}
Console.WriteLine();

Console.WriteLine("number of sorts: " );
Console.WriteLine(numbers[numbers.Count-1]);