class BujurSangkar : ILuasBangunDatar
{
    private double sisi;

    public BujurSangkar(double sisi)
    {
        this.sisi = sisi;
    }

    public double HitungLuas()
    {
        return sisi * sisi;
    }
}