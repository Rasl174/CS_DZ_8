using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string setName;
            string setPassword;
            string colorConsole;
            string userInput;

            Console.WriteLine("Добро пожаловать в программу. ");

            while (true)
            {
                Console.WriteLine("Выберите нужное действие: ");

                Console.WriteLine("1 - Установить имя");
                Console.WriteLine("2 - Установить пароль");
                Console.WriteLine("3 - Изменить цвет консоли");
                Console.WriteLine("4 - Выйти или ввести ESC");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Введите ваше имя: ");
                        setName = Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Введите пароль: ");
                        setPassword = Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Введите цвет консоли: red, blue, green. ");
                        colorConsole = Console.ReadLine();
                        Console.Clear();

                        if (colorConsole == "blue")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (colorConsole == "red")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (colorConsole == "green")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;


                    case "4":
                    case "ESC":
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                }


               

            }



        }
    }
}
