static void bubblesort(List<int> data)
{
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
                
            }
        }
    }
}
static int binarysearch(List<int> data, int search)
{
    int index = -1;

    if (data == null)
    {
        return -1;
    }

    int start = 0;
    int end = data.Count-1;
    while (start <= end)
    {
        int middle = (start+end)/2;


        if( search > data[middle])
        {
            start = middle +1;
        }
        else if( search < data[middle])
        {
            end = middle -1;
        }
        else
        {
            return middle;
        }
    }
    return -1;
}




List<int> numbers = new List<int> { 3, 4, 8, 3, 5, 8, 3, 5, 3, 2, 9 };

Console.WriteLine("search for number:");
int searchValue = int.Parse(Console.ReadLine());
bubblesort(numbers);

for (int i = 0; i < numbers.Count ; i++)
{
    Console.Write(numbers[i] + " ");

}

int index = binarysearch(numbers, searchValue);
if (index == -1)
{
    Console.WriteLine("error 404, data not found");
}
else
{
    Console.WriteLine("The number exist at index: " + index);
}
