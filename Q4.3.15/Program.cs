namespace Q4._3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Задайте одномерный массив и напишите алгоритм, 
             * который находит в нем количество положительных чисел.
             */

            int[] array = { 1, -2, 3, -4, 5, 6, 7, 8, 9, -10, 11, 12, 13, -14, 15, 16, };

            int nambers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0);
                nambers++;
            }
            Console.WriteLine(nambers);
        }
    }
}