using System.Xml.Linq;

namespace ConsoleSkill9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя!");
            string Name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (var ch in Name)
            {
                Console.WriteLine(ch + " ");
            }
            Console.WriteLine("Последняя буква вашего имени: {0}", Name[Name.Length - 1]);
            Console.WriteLine("Первая буква вашего имени: {0}", Name[0]);
            Console.WriteLine("Сейчас в обратном порядке:");
            for (int i = Name.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(Name[i] + " ");
            }
            Console.ReadKey();
        }
    }
}