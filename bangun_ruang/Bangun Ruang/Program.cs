public class Program
{
    public static void Main()
    {
        IBangunRuang[] bangunRuang = new BangunRuang[5];
        bangunRuang[0] = new Kubus(11);
        bangunRuang[1] = new Balok(6, 7, 8);
        bangunRuang[2] = new Bola(42);
        bangunRuang[3] = new Tabung(21, 5);
        bangunRuang[4] = new Kerucut(21, 29);

        Console.WriteLine("============================================================");
        Console.WriteLine("======================= Bangun Ruang =======================");
        Console.WriteLine("============================================================");
        foreach (var ruang in bangunRuang)
        {
            ruang.print();
        }
    }
}