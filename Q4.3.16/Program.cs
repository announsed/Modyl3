namespace Q4._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Давайте модифицируем нашу предыдущую задачу для работы с двумерным массивом. 
             * Необходимо найти количество положительных элементов массива.
             * 
             * Задан двумерный массив:
             * int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
             */

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int temp = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                temp++;
            }
            Console.WriteLine($"Это через цикл foreach:  {temp}");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > 0);
                        temp++;
                }
            }
            Console.WriteLine($"Это через цикл for:  {temp}");
        }
    }
}