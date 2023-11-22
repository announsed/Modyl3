namespace ConsoleSkill8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл do...while");
            int t = 0;
            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    
                    case "black":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor= ConsoleColor.White;
                        Console.WriteLine("BLAAACK EEEEE this is color perfect!!!!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Ты что-то ввел не то, поэтому используем default");
                        break;
                }
                t++;
            }
            while (t < 3);
        }
    }
}