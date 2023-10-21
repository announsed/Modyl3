namespace Q3._7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            var age = Console.ReadLine();
            Console.WriteLine("Ваше имя {0} и ваш возраст {1} ", name, age);
            Console.Write("Введи дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Дата твоего рождения: {0}", birthdate);
            Console.ReadKey();
            

        }
    }
}