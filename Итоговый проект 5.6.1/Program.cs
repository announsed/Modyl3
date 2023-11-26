namespace Итоговый_проект_5._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ALLUSER();
        }
        static string ALLUSER()
        {
            (string Name, string Name2, int age, string[] pet, string[] color) user;
            Console.WriteLine(" Введите свое имя: ");
            user.Name = Console.ReadLine();
            if (!IsCorrect(user.Name))
            {
                while (true)
                {
                    Console.WriteLine(" Введите корректные данные!!!");
                    user.Name = Console.ReadLine();
                    return user.Name;
                }
                
            }
            Console.WriteLine(" Введите свою фамилию: ");
            user.Name2 = Console.ReadLine();
            if (!IsCorrect(user.Name2))
            {
                while (true)
                {
                    Console.WriteLine(" Введите корректные данные!!!");
                    user.Name2 = Console.ReadLine();
                    return user.Name2;
                }
            }
            Console.WriteLine(" Введите свой возраст: ");
            string StrAge = Console.ReadLine();
            if (IsCorrect(StrAge)) 
            {
                while (true)
                {
                    Console.WriteLine(" Введите корректные данные!!!");
                    StrAge = Console.ReadLine();
                    return StrAge;
                }
            }
            user.age = int.Parse(StrAge);
            Console.WriteLine(" У вас есть питомец? ");
            string UserOtvetPet = Console.ReadLine();
            if (!IsCorrect(UserOtvetPet))
            {
                while (true)
                {
                    Console.WriteLine(" Введите корректные данные!!!");
                    UserOtvetPet = Console.ReadLine();
                    return UserOtvetPet;
                }
            }
            string[] PetGive = { "да", "Да", "ДА", " " };
            string[] PetGive2 = { "нет", "Нет", "НЕТ" };
            user.pet = new string[0];
            foreach (string Otvet in PetGive)
            {
                if (Otvet == UserOtvetPet)
                {
                    Console.WriteLine(" Ого, здорово, а сколько вообще питомцев?");
                    string StrAdvansed = Console.ReadLine();
                    if (IsCorrect(StrAdvansed))
                    {
                        while (true)
                        {
                            Console.WriteLine(" Введите корректные данные!!!");
                            StrAdvansed = Console.ReadLine();
                            return StrAdvansed;
                        }
                    }
                    int advansed = int.Parse(StrAdvansed);
                    string[] petarr = new string[advansed];
                    for (int i = 0; i < petarr.Length; i++)
                    {
                        Console.WriteLine($" Введите кличку вашего {i + 1} питомца ;)");
                        petarr[i] = Console.ReadLine();
                        if (!IsCorrect(petarr[i]))
                        {
                            while (true)
                            {
                                Console.WriteLine(" Введите корректные данные!!!");
                                petarr[i] = Console.ReadLine();
                                return petarr[i];
                            }
                        }
                    }
                    foreach (string petname in petarr)
                    {
                        Console.WriteLine($" Отлично, вы ввели кличку вашего питомца {petname}");
                    }
                    user.pet = petarr;
                    string outpetter = string.Join(",", user.pet);
                }
            }
            foreach (string Otvet in PetGive2)
            {
                if (Otvet == UserOtvetPet)
                {
                    Console.WriteLine(" Как жаль, что нет питомца (");
                }
            }
            Console.WriteLine(" О, а напиши, количество твоих любимых цветов");
            string StrUserLoveColor = Console.ReadLine();
            if (IsCorrect(StrUserLoveColor))
            {
                while (true)
                {
                    Console.WriteLine(" Введите корректные данные!!!");
                    StrUserLoveColor = Console.ReadLine();
                    return StrUserLoveColor;
                }
            }
            int UserLoveColor = int.Parse(StrUserLoveColor);
            string[] UserColor = new string[UserLoveColor];
            for (int i = 0; i < UserColor.Length; i++)
            {
                Console.WriteLine($" Введи на русском языке с маленькой буквы цвет {i + 1}");
                UserColor[i] = Console.ReadLine();
                if (!IsCorrect(UserColor[i]))
                {
                    while (true)
                    {
                        Console.WriteLine(" Введите корректные данные!!!");
                        UserColor[i] = Console.ReadLine();
                        return UserColor[i];
                    }
                }
                string colorText = UserColor[i];
                switch (colorText)
                {
                    case "черный":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ты ввел(а) цвет черный!");
                        break;
                    case "синий":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет синий!");
                        break;
                    case "голубой":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет голубой!");
                        break;
                    case "темно-синий":
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) темно-синий!");
                        break;
                    case "темно-голубой":
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) темно-голубой!");
                        break;
                    case "темно-серый":
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет темно-серый!");
                        break;
                    case "темно-зеленый":
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет темно-зеленый!");
                        break;
                    case "темно-фиолетовый":
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет темно-фиолетовый!");
                        break;
                    case "темно-красный":
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет темно-красный!");
                        break;
                    case "темно-желтый":
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет темно-желтый!");
                        break;
                    case "серый":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет серый!");
                        break;
                    case "зеленый":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет зеленый!");
                        break;
                    case "фиолетовый":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет фиолетовый!");
                        break;
                    case "красный":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет красный!");
                        break;
                    case "белый":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ты ввел(а) цвет белый!");
                        break;
                    case "желтый":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Твой цвет желтый!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"К сожалению введенный вами цвет {UserColor[i]} в этом скромном коде не обнаружен(.");
                        break;
                }
            }
            foreach (string UsColor in UserColor)
            {
                Console.WriteLine($" Отлично, вы ввели один из ваших любимых цветов {UsColor}");
            }
            user.color = UserColor;
            string outcolor = string.Join( ",", user.color );
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($" И так, ваше имя: {user.Name} \n Ваша фамилия: {user.Name2} \n Ваш возраст: {user.age} лет \n Животные: {null} \n Цвета: {outcolor}");
            Console.ReadKey();
            return outcolor;
        }   
        static bool IsCorrect(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '0'
                    || name[i] == '1'
                    || name[i] == '2' 
                    || name[i] == '3' 
                    || name[i] == '4' 
                    || name[i] == '5' 
                    || name[i] == '6'
                    || name[i] == '7'
                    || name[i] == '8' 
                    || name[i] == '9')
                {
                   return false;
                }
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 0)
                {
                    return true;
                }
            }
            return true;
        }
    }
}
