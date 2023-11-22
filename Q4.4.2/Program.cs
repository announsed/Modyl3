namespace Q4._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.Write("Введите ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Смотри чти в итоге получается: ");
            Console.WriteLine("Твое имя это: {0}", anketa.Item1);
            Console.WriteLine("Твой возраст это: {0}", anketa.Item2);
            Console.ReadKey();

        }
    }
}
