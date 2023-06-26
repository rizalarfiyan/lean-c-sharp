class Kubus: BangunRuang, IBangunRuang
{
    public string name = "Kubus";

    private double sisi;

    public Kubus(double sisi)
    {
        this.sisi = sisi;
    }

    public override double hitungVolume()
    {
        return Math.Pow(sisi, 3);
    }

    public override double hitungLuasPermukaan()
    {
        return 6 * Math.Pow(sisi, 2);
    }

    public override void printInput()
    {
        Console.WriteLine("Bangun ruang {0}:", name);
        Console.WriteLine("Sisi: {0}", sisi);
    }
}