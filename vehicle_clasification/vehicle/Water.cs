using static vehicle_clasification.Constants;


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
    }
}
