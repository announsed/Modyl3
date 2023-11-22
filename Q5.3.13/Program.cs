using System.Globalization;

namespace Q5._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void SortArray(in int[] arry, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(arry);
            sortedasc = SortArrayAsc(arry);
        }
        static int[] SortArrayDesc(int[] result1)
        {
            for (int i = 0; i > result1.Length; i++)
            {
                Console.Write(result1[i] + " ");
            }
            return result1;
        }
        static int[] SortArrayAsc(int[] result2)
        {
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write(result2[i] + " ");
            }
            return result2;
        }
    }
}
