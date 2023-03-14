using static vehicle_clasification.Constants;

namespace vehicle_clasification.vehicle
{
    internal class Land : Vehicle
    {
        protected int Wheel { get; set; }

        public Land()
        {
            this.Type = VehicleType.Land;
        }

        public override void Input()
        {
            base.Input();

            this.Wheel = this.InputInteger("wheel");
        }

        public override void Result()
        {
            base.Result();

            Console.WriteLine(" - Wheel\t\t: {0}", this.Wheel);

            Console.Write("\n");
            Closing();
        }
    }
}
