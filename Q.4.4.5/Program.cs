namespace Q._4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Хэй, расскажешь немного про своего питомца??");
            Console.WriteLine("Как его зовут???");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Хорошее имя: {0}", Pet.Name);
            Console.WriteLine("Воу, воу, мы не спросили, а что вообще за животное?:)");
            Console.WriteLine("И так, что за зверь?");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Как мило!)");
            Console.WriteLine("А сколько ему?");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Как примечательно, ему {0}", Pet.Age);
            Pet.NameCount = Pet.Name.Length;
            for (int i = 0; i < Pet.NameCount; i++)
            {
                int summ = 0;
                summ += i;
            }
            Console.WriteLine("И так, твоего питомца зовут {0}, вид твоего питомца: {1}, ему {2} лет, его имя состоит из {3} букв", Pet.Item1, Pet.Item2, Pet.Item3, Pet.Item4);
            Console.WriteLine("Было интересно");
            Console.ReadKey();

        }
    }
}
