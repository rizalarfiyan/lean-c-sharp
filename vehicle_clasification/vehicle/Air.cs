using static vehicle_clasification.Constants;


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
    }
}
