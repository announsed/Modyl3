namespace Q4._1._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на русском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "красный")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Твой цвет красный!");
            }

            else if (color == "зеленый")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Твой цвет зеленый!");
            }
            else if (color == "голубой")
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Твой цвет голубой!");
            }
            else if (color == "желтый")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Твй цвет желтый!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ты ввел чтото отличное от цветов которые мы знаем!");
                Console.WriteLine("А мы знаем только - красный, зеленый, голубой, желтый!");
                Console.WriteLine("Кароче, на те вишневый какой-то!!:>");


            }
            Console.ReadKey();

        }
    }
}