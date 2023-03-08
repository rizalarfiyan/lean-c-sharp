using System;

namespace CalculatorApps
{
    class Program
    {
        static int Sum(int firstvalue, int secondvalue)
        {
            return firstvalue + secondvalue;
        }

        static int Subtraction(int firstvalue, int secondvalue)
        {
            return firstvalue - secondvalue;
        }

        static int Multiply(int firstvalue, int secondvalue)
        {
            return firstvalue * secondvalue;
        }

        static int Division(int firstvalue, int secondvalue)
        {
            return firstvalue / secondvalue;
        }

        static void PrintAppName()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("--------------------- Calculator Apps ---------------------");
            Console.WriteLine("---------------- @rizalarfiyan - 22.11.5227 ---------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            const int MAX_MENU = 4;

            main:
            int chooseMenu, firstvalue, secondvalue;
            Console.Title = "Calculator Apps";
            Console.Clear();
            PrintAppName();

            Console.WriteLine(" Menu: ");
            Console.WriteLine(" 1. Sum");
            Console.WriteLine(" 2. Subtraction");
            Console.WriteLine(" 3. Multiply");
            Console.WriteLine(" 4. Division");
            Console.WriteLine();

            chose_menu:
            Console.Write("Choose your menu: ");
            if (!int.TryParse(Console.ReadLine(), out chooseMenu))
            {
                Console.Write("Please input a valid number!\n");
                goto chose_menu;
            }

            if (chooseMenu < 0 || chooseMenu > MAX_MENU)
            {
                Console.Write("Please input number between 1-{0}\n", MAX_MENU);
                goto chose_menu;
            }

            input_first_value:
            Console.Write("\nInput fist value: ");
            if (!int.TryParse(Console.ReadLine(), out firstvalue))
            {
                Console.Write("Please input a valid number!\n");
                goto input_first_value;
            }

            input_second_value:
            Console.Write("\nInput second value: ");
            if (!int.TryParse(Console.ReadLine(), out secondvalue))
            {
                Console.Write("Please input a valid number!\n");
                goto input_second_value;
            }

            switch (chooseMenu)
            {
                case 1:
                    Console.WriteLine("Result Sum of {0} + {1} = {2}", firstvalue, secondvalue, Sum(firstvalue, secondvalue));
                    break;
                case 2:
                    Console.WriteLine("Result Subtraction of {0} - {1} = {2}", firstvalue, secondvalue, Subtraction(firstvalue, secondvalue));
                    break;
                case 3:
                    Console.WriteLine("Result Multiply of {0} * {1} = {2}", firstvalue, secondvalue, Multiply(firstvalue, secondvalue));
                    break;
                case 4:
                    Console.WriteLine("Result Division of {0} / {1} = {2}", firstvalue, secondvalue, Division(firstvalue, secondvalue));
                    break;
            }

            Console.Write("\nPress y or Y to continue: ");
            char confirm = Console.ReadKey().KeyChar;
            if (confirm == 'y' || confirm == 'Y')
            {
                goto main;
            }

            Console.Write("\n\n");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("------------------------ Thank You ------------------------");
            PrintAppName();
        }
    }
}