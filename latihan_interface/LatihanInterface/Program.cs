class Program
{
    static void Main(string[] args)
    {
        BangunDatar[] bangunDatar = new BangunDatar[3]; 
        bangunDatar[0] = new BujurSangkar(5);
        bangunDatar[1] = new PersegiPanjang(4, 6);
        bangunDatar[2] = new Segitiga(3, 8);

        foreach (BangunDatar bangun in bangunDatar)
        {
            bangun.Result();
        }
    }
}