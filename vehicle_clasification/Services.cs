using vehicle_clasification.vehicle;
using static vehicle_clasification.Constants;

namespace vehicle_clasification
{
    internal class Services
    {
        private int choose { get; set; }

        public void ChooseInput()
        {
        choose_menu:
            int chooseMenu;
            Console.Write("Choose type of vehicle: ");
            if (!int.TryParse(Console.ReadLine(), out chooseMenu))
            {
                Console.Write("Please input a valid number!\n\n");
                goto choose_menu;
            }

            chooseMenu--;
            int maxMenu = VehicleTypeLists().Length;
            if (chooseMenu < 0 || chooseMenu > maxMenu)
            {
                Console.Write("Please input number between 1-{0}\n\n", maxMenu);
                goto choose_menu;
            }

            this.choose = chooseMenu;
        }

        public void PrintMenu()
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("========================= Clasification of Vehicle =========================");
            Console.WriteLine("============================= by @rizalarfiyan =============================");
            Console.WriteLine("============================================================================");
            Console.WriteLine();
            Console.WriteLine("Type of Vehicle: ");
            string[] jenisKendaraan = VehicleTypeLists();
            for (int i = 0; i < jenisKendaraan.Length; i++)
            {
                Console.WriteLine("[{0}] {1} vehicle", i + 1, jenisKendaraan[i]);
            }
            Console.WriteLine();
        }

        public void ChooseQuery()
        {
            switch (this.choose)
            {
                case (int)VehicleType.Air:
                    new Air().Run();
                    break;
                case (int)VehicleType.Land:
                    new Land().Run();
                    break;
                case (int)VehicleType.Water:
                    new Water().Run();
                    break;
            }
        }

        public void Run()
        {
            this.PrintMenu();
            this.ChooseInput();
            this.ChooseQuery();
        }
    }
}
