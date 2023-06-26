class Bola: BangunRuang, IBangunRuang
{
    public string name = "Bola";

    private double jariJari;

    public Bola(double jariJari)
    {
        this.jariJari = jariJari;
    }

    public override double hitungVolume()
    {
        return 4/3 * Math.PI * Math.Pow(jariJari, 3);
    }

    public override double hitungLuasPermukaan()
    {
        return 4 * Math.PI * Math.Pow(jariJari, 2);
    }
    public override void printInput()
    {
        Console.WriteLine("Bangun ruang {0}:", name);
        Console.WriteLine("Jari-jari: {0}", jariJari);
    }
}