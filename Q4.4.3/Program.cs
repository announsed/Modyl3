namespace Q4._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anketa = (name: "Евгений", age: 27);
            Console.WriteLine("Твое имя: {0}", anketa.Item1);
            Console.WriteLine("Твой возраст: {0}", anketa.Item2);

            Console.WriteLine("Напиши заново имя и возраст!");
            Console.WriteLine("Твое имя: ");
            Console.ReadLine();
            Console.WriteLine("Твой возраст: ");
            Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
