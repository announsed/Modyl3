using System.Xml.Linq;

namespace Q5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var changename = "Евгения";
            var age = 99;
            Console.WriteLine(changename);
            GetName(ref changename);
            Console.WriteLine(changename);
            
            Console.WriteLine("Введите возраст: ");
            Console.WriteLine(age);
            ChangeAge(age);
            Console.WriteLine(age);
        }
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
        }
        static void ChangeAge(int age)
        {
            age = int.Parse(Console.ReadLine());
        }
        static void ChangName(ref int num)
        {

        }
    }
}
