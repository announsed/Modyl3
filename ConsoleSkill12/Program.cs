namespace ConsoleSkill12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string [] Dishes ) User;
            Console.WriteLine("Имя пользователя: ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Напиши свои 5 любимых блюд: ");
            User.Dishes = new string [5];
            for (int i = 0; User.Dishes.Length > i; i++)
            {
                Console.WriteLine("Любимое блюдо номер: {0}", i+1);
                User.Dishes[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
