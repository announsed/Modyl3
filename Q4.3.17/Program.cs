namespace Q4._3._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Одной из нетривиальных задач является задача сортировки двумерного массива. 
             * Как минимум, не слишком понятно, как же сортировать, 
             * есть ведь «строки» и «столбцы». Как требуется проводить сортировку?
             * В данном случае давайте реализуем просто сортировку элементов массива 
             * внутри одной строки.  
             * 
             * Задан массив:
             * int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
             */

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int temp = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, j] > arr[i, k]) 
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[j, i];
                            arr[j, i] = temp;
                        }
                    }

                }
            }
            Console.WriteLine(temp);
        }
    }
}