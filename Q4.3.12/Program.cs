namespace Q4._3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Задан массив:
             * var arr = new int[] { 5, 6, 9, 1, 2, 3, 4};
             * Вам необходимо отсортировать его в порядке возрастания цифр и 
             * вывести на экран.
             */

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}