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

        static void Main(string[] args)
        {
            Console.Title = "Calculator Apps";
            const int MAX_MENU = 4;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("--------------------- Calculator Apps ---------------------");
            Console.WriteLine("---------------- @rizalarfiyan - 22.11.5227 ---------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(" Menu: ");
            Console.WriteLine(" 1. Sum");
            Console.WriteLine(" 2. Subtraction");
            Console.WriteLine(" 3. Multiply");
            Console.WriteLine(" 4. Division");
            Console.WriteLine();

            Console.Write("Choose your menu: ");
            int chooseMenu = Convert.ToInt32(Console.ReadLine());
            if (chooseMenu < 0 || chooseMenu > MAX_MENU)
            {
                Console.WriteLine("Please input number between 1-{0}", MAX_MENU);
                System.Environment.Exit(0);
            }

            Console.Write("Input fist value: ");
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second value: ");
            int secondvalue = Convert.ToInt32(Console.ReadLine());

            switch (chooseMenu)
            {
                case 1:
                    Console.WriteLine("Result Sum of {0} + {1} = {3}", firstvalue, secondvalue, Sum(firstvalue, secondvalue));
                    break;
                case 2:
                    Console.WriteLine("Result Subtraction of {0} - {1} = {3}", firstvalue, secondvalue, Subtraction(firstvalue, secondvalue));
                    break;
                case 3:
                    Console.WriteLine("Result Multiply of {0} * {1} = {3}", firstvalue, secondvalue, Multiply(firstvalue, secondvalue));
                    break;
                case 4:
                    Console.WriteLine("Result Division of {0} / {1} = {3}", firstvalue, secondvalue, Division(firstvalue, secondvalue));
                    break;
            }
        }
    }
}