namespace SelectionSort
{
    class Program
    {
        static void SelectionSort(string[] args)
        {
            int [] array = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}