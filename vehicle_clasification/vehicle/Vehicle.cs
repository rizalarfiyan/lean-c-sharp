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
                Console.Write("Please input a string!\n\n");
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
            return readBool;
        }

        protected int InputInteger(string name)
        {
        input:
            int chooseMenu;
            Console.Write("\nInput {0} of {1} Vehicle: ", name, this.Type);
            if (!int.TryParse(Console.ReadLine(), out chooseMenu))
            {
                Console.Write("Please input a valid number!\n\n");
                goto input;
            }

            if (chooseMenu < 0)
            {
                Console.Write("Please input number same or more than zero!\n\n");
                goto input;
            }

            return chooseMenu;
        }

        public virtual void Input()
        {
            this.Name = InputString("name");
            this.Machine = InputString("machine");
            this.Fuel = InputString("fuel");
        }

        public virtual void Result()
        {
            Console.WriteLine("Result of {0}", this.Type);
        }

        public virtual void Run()
        {
            this.Input();
            this.Result();
        }
    }
}
