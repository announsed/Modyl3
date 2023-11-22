namespace Test
{
    internal class Program
    {
        static void Main(string[] args, decimal b)
        {
            //запуск просмотра области интовских начений
            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
            //рекурсия
            b = Factorial(20);
            Console.WriteLine(b);
            //рекурсивный метод, который возводит введенное число N типа int
            //в указанную степень pow типа byte.
            Console.WriteLine(PowerUp(4, 5));
            Console.ReadKey();
        }
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}