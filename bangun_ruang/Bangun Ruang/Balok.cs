class Balok: BangunRuang, IBangunRuang
{
    public string name = "Balok";

    private double panjang;
    private double lebar;
    private double tinggi;

    public Balok(double panjang, double lebar, double tinggi)
    {
        this.panjang = panjang;
        this.lebar = lebar;
        this.tinggi = tinggi;
    }

    public override double hitungVolume()
    {
        return panjang * lebar * tinggi;
    }

    public override double hitungLuasPermukaan()
    {
        return 2 * ((panjang * lebar) + (lebar * tinggi) + (panjang * tinggi));
    }

    public override void printInput()
    {
        Console.WriteLine("Bangun ruang {0}:", name);
        Console.WriteLine("Panjang: {0}", panjang);
        Console.WriteLine("Lebar: {0}", lebar);
        Console.WriteLine("tinggi: {0}", tinggi);
    }
}