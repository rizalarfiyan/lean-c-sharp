namespace vehicle_clasification
{
    internal class Constants
    {
        public enum VehicleType
        {
            Air,
            Land,
            Water,
        };

        public static readonly string[] VehicleTypeName = {
            "Air",
            "Land",
            "Water"
        };

        public static string getVehicleType(VehicleType enumData)
        {
            return VehicleTypeName[(int)enumData];
        }

        public static string[] VehicleTypeLists()
        {
            return new string[] {
                getVehicleType(VehicleType.Air),
                getVehicleType(VehicleType.Land),
                getVehicleType(VehicleType.Water),
            };
        }
    }
}
