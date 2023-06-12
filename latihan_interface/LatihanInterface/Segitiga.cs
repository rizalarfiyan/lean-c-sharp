class Segitiga : BangunDatar, ILuasBangunDatar
{
    private double alas;
    private double tinggi;

    public Segitiga(double alas, double tinggi)
    {
        this.alas = alas;
        this.tinggi = tinggi;
    }

    public override double HitungLuas()
    {
        return 0.5 * alas * tinggi;
    }
}