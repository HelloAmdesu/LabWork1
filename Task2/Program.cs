class Program
{
    public static int BubbleSort()
    {
        int[] array = { 7, 10, 3, 8, 9, 2, 15, 1, 4, 6, 12 };

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }


        Console.WriteLine("Вывод отсортированного массива: ");
        foreach (var i in array)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine();

        return 0;
    }
}