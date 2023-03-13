using static vehicle_clasification.Constants;

namespace vehicle_clasification.vehicle
{
    internal class Vehicle
    {
        public VehicleType Type { set; get; }
        public string? Name { set; get; }

        public virtual void Input()
        {
            Console.WriteLine("Input of {0}", this.Type);
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
