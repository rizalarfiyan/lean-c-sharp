using static vehicle_clasification.Constants;
using static vehicle_clasification.vehicle.Vehicle;

namespace vehicle_clasification.vehicle
{
    internal class Air : Vehicle
    {
        protected int Seat { get; set; }
        protected Boolean IsCommercial { get; set; }

        public Air()
        {
            this.Type = VehicleType.Air;
        }

        public override void Input()
        {
            base.Input();

            this.Seat = this.InputInteger("seat");
            this.IsCommercial = this.InputBoolean("is commercial");
        }

        public override void Result()
        {
            base.Result();

            Console.WriteLine(" - Seat\t\t\t: {0}", this.Seat);
            Console.WriteLine(" - Is Commercial\t: {0}", BooleanToString(this.IsCommercial));

            Console.Write("\n");
            Closing();
        }
    }
}
