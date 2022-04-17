using System;

namespace ConsoleApp4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            string setName = "Samchik";
            string color;
            string setPassword = "1qa2ws3ed";
            DateTime localDate = DateTime.Now;
            char namber;
            string writeName;
            char num;
            while (menu)
            {
                Console.Clear();

                Console.WriteLine(setName + @" введите номер кода
1 - SetName - установить имя.
2 - Color - установить цвет.
3 - SetPassword - установить пароль.
4 - WriteName – вывести имя (после ввода пароля).
5 - Время - Показать текущее время.
6 - Игра Больше Меньше.
7 - Esc – выход из программы.
8 - Цель задания");
                namber = char.Parse(Console.ReadLine());
                switch (namber)
                {
                    case '1':
                        Console.Write($"Ваше имя {setName} введите новое имя: ");
                        setName = Convert.ToString(Console.ReadLine());
                        break;

                    case '2':
                        Console.WriteLine("Введите цвет [red, blue, white, green, yellow и magenta");
                        string argument = Convert.ToString(Console.ReadLine());
                        switch (argument)
                        {
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "white":
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "green":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "yellow":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case "magenta":
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            default:
                                Console.WriteLine("Я не понимаю тебя, мой друг.");
                                break;
                        }
                        break;
                    case '3':
                        Console.Write($"Вашь пароль {setPassword} введите новый пароль: ");
                        setPassword = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Вашь пароль " + setPassword);
                        break;
                    case '4':
                        Console.Write("Введите пароль: ");
                        Console.Write("введите пароль перед: ");

                        var psw = Console.ReadLine();
                        if (psw == setPassword)
                        {
                            Console.WriteLine("Имя пользователя " + setName);
                            Console.WriteLine("Нажмите 1 для выхода в обратное меню");
                            num = char.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Неправильный пароль!");
                            Console.WriteLine("Нажмите 1 для выхода в обратное меню");
                            num = char.Parse(Console.ReadLine());
                        }
                        break;
                    case '5':
                        Console.WriteLine(localDate);
                        Console.WriteLine("Нажмите 1 для выхода в обратное меню");
                        num = char.Parse(Console.ReadLine());
                        break;

                    case '6':
                    ggames:
                        Random ran = new Random();
                        int value = ran.Next(1, 25);
                        byte hp = 5;
                        Console.WriteLine("У вас 5 попыток");
                    game:
                        Console.WriteLine("Введите число от 1 до 25");
                        int namber1 = int.Parse(Console.ReadLine());
                        if (value < namber1 && hp > 1)
                        {
                            Console.WriteLine("Загаданное число меньше");
                            hp--;
                            goto game;
                        }
                        if (value > namber1 && hp > 1)
                        {
                            Console.WriteLine("Загаданное число больше");
                            hp--;
                            goto game;
                        }
                        if (value == namber1)
                        {
                            Console.WriteLine("Поздравляю! \nВы угадали");
                        }
                        else
                        {
                            Console.WriteLine("К сожалению вы не угадали");
                        }
                        Console.WriteLine("Хотите заного сыграть? 1-да или 2-нет");
                        string nex = Convert.ToString(Console.ReadLine());
                        switch (nex)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Играем заного");
                                goto ggames;
                                break;
                            case "2":
                                Console.WriteLine("Всего доброго!");
                                break;
                        }
                        break;

                    case '7':
                        menu = false;
                        break;

                    case '8':
                        Console.WriteLine(@"Задача:
• При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды. Т.е. вы создаете меню, 
ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
• Примеры команд (Требуется 4-6 команд, придумать самим)
• SetName – установить имя
• ChangeConsoleColor- изменить цвет консоли
• SetPassword – установить пароль
• WriteName – вывести имя (после ввода пароля)
• Esc – выход из программы
• Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.");
                        Console.WriteLine("Нажмите 1 для выхода в обратное меню");
                        num = char.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Вы ввели не верный номер");
                        break;
                }
            }
        }
    }
}