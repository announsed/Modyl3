using System.Xml.Linq;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("That you name? ");
            var name = Console.ReadLine();
            Console.Write("Пиши возраст: ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day of week? ");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            var howItall = 162;
            var myshoe = 37.5;
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.WriteLine("What is my grouth? {0} sm", howItall);
            Console.WriteLine("What is my shoe size? {0}", myshoe);
        }
    }
}