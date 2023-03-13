using vehicle_clasification;

namespace KlasifikasiKendaraan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services service = new Services();
            service.PrintMenu();
            service.ChooseInput();
        }
    }
}