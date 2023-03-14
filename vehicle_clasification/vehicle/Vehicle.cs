using System.Xml.Serialization;
using static vehicle_clasification.Constants;

namespace vehicle_clasification.vehicle
{
    internal class Vehicle
    {
        protected VehicleType Type { set; get; }
        protected string? Name { set; get; }
        protected string? Machine { set; get; }
        protected string? Fuel { set; get; }

        protected string InputString(string name)
        {
            input:
            Console.Write("\nInput {0} of {1} Vehicle: ", name, this.Type);
            string? readStr = Console.ReadLine();
            if (readStr == null)
            {
                Console.Write("Please input a string!\n");
                goto input;
            }
            return readStr;
        }

        protected Boolean InputBoolean(string name)
        {
            Boolean readBool = false;
            Console.Write("\nPress y or Y to true and n or N to false");
            Console.Write("\nInput {0} of {1} Vehicle: ", name, this.Type);
            char confirm = Console.ReadKey().KeyChar;
            if (confirm == 'y' || confirm == 'Y')
            {
                readBool = true;
            }
            Console.Write("\n\n");
            return readBool;
        }

        protected int InputInteger(string name)
        {
        input:
            int chooseMenu;
            Console.Write("\nInput {0} of {1} Vehicle: ", name, this.Type);
            if (!int.TryParse(Console.ReadLine(), out chooseMenu))
            {
                Console.Write("Please input a valid number!\n");
                goto input;
            }

            if (chooseMenu < 0)
            {
                Console.Write("Please input number same or more than zero!\n");
                goto input;
            }

            return chooseMenu;
        }

        public static string BooleanToString(Boolean state)
        {
            return state ? "true" : "false";
        }

        public static void Greeting()
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("========================= Clasification of Vehicle =========================");
            Console.WriteLine("============================= by @rizalarfiyan =============================");
            Console.WriteLine("============================================================================");
        }

        public virtual void Input()
        {
            this.Name = InputString("name");
            this.Machine = InputString("machine");
            this.Fuel = InputString("fuel");
        }

        public virtual void Result()
        {
            Console.Clear();
            Greeting();
            Console.WriteLine();
            Console.WriteLine("Result of {0} Vehicle Classification", this.Type);
            Console.WriteLine(" - Name\t\t\t: {0}", this.Name);
            Console.WriteLine(" - Machine\t\t: {0}", this.Machine);
            Console.WriteLine(" - Fuel\t\t\t: {0}", this.Fuel);
        }

        public virtual void Run()
        {
            this.Input();
            this.Result();
        }
    }
}
