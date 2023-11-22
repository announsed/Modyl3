namespace Q5._2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var b = GetArrayFromConsole();
            SortArray(b);
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        static int[] SortArray(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
            return result;
        }
    }
}
