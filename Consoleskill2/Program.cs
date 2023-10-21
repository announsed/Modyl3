namespace Consoleskill2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Меня зовут Сергей!";
            byte age = 21;
            Console.WriteLine($"{name},\n{age}");
            bool yes = true;
            Console.WriteLine($"Есть лии у вас питомец?,\n{(yes?"DA":"NET")}");
            double sizefoot = 45;
            Console.WriteLine($"Мой размер ноги {sizefoot}");
            Console.ReadKey();




        }
    }
}