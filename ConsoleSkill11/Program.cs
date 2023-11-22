namespace ConsoleSkill11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Программа немного закрепляющая 4-ый модуль
             */
            (string imya, string familiya, string Login, int LoginLength, bool givotnoe, string[] likecolor, double vozrast) User;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите имя");
                User.imya = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.familiya = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    User.givotnoe = true;
                }
                else
                {
                    User.givotnoe = false;
                }
                Console.WriteLine($"Твой ответ: {result}");
                Console.WriteLine("Введите возраст пользователя");
                User.vozrast = double.Parse(Console.ReadLine());
                User.likecolor = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.likecolor.Length; i++)
                {
                    User.likecolor[i] = Console.ReadLine();
                }
                Console.ReadKey();
            }
        }
    }
}
