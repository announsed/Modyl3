namespace Q5._2._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arry = GetArrayFromConsole(10);
            ShowArray(arry, true);
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
        static void ShowArray(int[] arry, bool IsShort = false)
        {
            var temp = arry;
            if (IsShort)
            {
                temp = arry;
            }
            foreach (int item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
