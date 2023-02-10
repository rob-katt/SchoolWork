namespace Linear_search
{

        internal class Program
        {
            static void Main(string[] args)
            {

                static int linearsearch(List<int> data, int search)
                {
                    int index = -1;

                    if (data == null)
                    {
                        return -1;
                    }

                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i] == search)
                        {
                            index = i;
                            break;
                        }
                    }
                    return index;
                }




                List<int> numbers = new List<int> { 3, 4, 8, 3, 5, 8, 2, 3, 5, 3, 2, 6 };

                Console.WriteLine("search for number:");
                int searchValue = int.Parse(Console.ReadLine());
                int index = linearsearch(numbers, searchValue);
                if (index == -1)
                {
                    Console.WriteLine("error 404, data not found");
                }
                else
                {
                    Console.WriteLine("The number exist at index: " + index);
                }











            }
        }


}