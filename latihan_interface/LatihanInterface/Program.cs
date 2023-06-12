class Program
{
    static void Main(string[] args)
    {
        ILuasBangunDatar[] bangunDatar = new ILuasBangunDatar[3];
        bangunDatar[0] = new BujurSangkar(5);
        bangunDatar[1] = new PersegiPanjang(4, 6);
        bangunDatar[2] = new Segitiga(3, 8);

        foreach (ILuasBangunDatar bangun in bangunDatar)
        {
            double luas = bangun.HitungLuas();
            Console.WriteLine("Luas: " + luas);
        }

    }
}