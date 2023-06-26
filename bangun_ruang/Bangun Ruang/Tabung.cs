class Tabung: BangunRuang, IBangunRuang
{
    public string name = "Tabung";

    private double jariJari;
    private double tinggi;

    public Tabung(double jariJari, double tinggi)
    {
        this.jariJari = jariJari;
        this.tinggi = tinggi;
    }

    public override double hitungVolume()
    {
        return Math.PI * Math.Pow(jariJari, 3) * tinggi;
    }

    public override double hitungLuasPermukaan()
    {
        return 2 * Math.PI * jariJari * tinggi;
    }

    public override void printInput()
    {
        Console.WriteLine("Bangun ruang {0}:", name);
        Console.WriteLine("Jari-jari: {0}", jariJari);
        Console.WriteLine("Tinggi: {0}", tinggi);
    }
}