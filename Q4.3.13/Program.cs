using System.Diagnostics.CodeAnalysis;

namespace Q4._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Для заданного массива:
             * var arr = new int[] { 5, 6, 9, 1, 2, 3, 4};
             * Необходимо найти сумму всех его элементов.
             */

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
             Console.WriteLine(sum);
        }
    }
}