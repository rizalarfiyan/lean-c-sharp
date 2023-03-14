using static vehicle_clasification.Constants;
using static vehicle_clasification.vehicle.Vehicle;

namespace vehicle_clasification.vehicle
{

    internal class Water : Vehicle
    {
        protected Boolean HasMachine { get; set; }

        public Water()
        {
            this.Type = VehicleType.Water;
        }

        public override void Input()
        {
            base.Input();

            this.HasMachine = this.InputBoolean("has machine");
        }

        public override void Result()
        {
            base.Result();

            Console.WriteLine(" - Has Machine\t\t: {0}", BooleanToString(this.HasMachine));

            Console.Write("\n");
            Closing();
        }
    }
}
