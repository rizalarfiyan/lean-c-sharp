class Kerucut : BangunRuang, IBangunRuang
{
    public string name = "Kerucut";

    private double jariJari;
    private double tinggi;

    public Kerucut(double jariJari, double tinggi)
    {
        this.jariJari = jariJari;
        this.tinggi = tinggi;
    }

    public override double hitungVolume()
    {
        return 1/3 * Math.PI * Math.Pow(jariJari, 2) * tinggi;
    }

    public override double hitungLuasPermukaan()
    {
        double garisPelukir = Math.Sqrt(Math.Pow(jariJari, 2) + Math.Pow(tinggi, 2));
        return Math.PI * jariJari * (garisPelukir + jariJari);
    }

    public override void printInput()
    {
        Console.WriteLine("Bangun ruang {0}:", name);
        Console.WriteLine("Jari-jari: {0}", jariJari);
        Console.WriteLine("Tinggi: {0}", tinggi);
    }
}