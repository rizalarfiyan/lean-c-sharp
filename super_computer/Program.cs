namespace super_computer
{
    class Program
    {
        static void Main(string[] args)
        {

            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102", 50);

            Vga nvidiaVga = new Vga("Nvigia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 2054);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(8);
            intelProcessor.setSeries("CORE i& 8th Gen");

            Computer computer = new Computer.Builder(samsungRam, nvidiaVga, intelProcessor).withMonitor(lgMonitor).withPrinter(hpPrinter).build();
            Console.WriteLine(computer.ToString());
        }
    }
}