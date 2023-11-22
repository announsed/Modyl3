namespace Q5._2._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = {1, 3, 56, 34, 23, 9890, 4536, 234135, 5375};
            var soda = ShowArray(arry, false);
        }
        static int[] ShowArray(int[] arry, bool IsShort = false)
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
            return arry;
        }
    }
}
