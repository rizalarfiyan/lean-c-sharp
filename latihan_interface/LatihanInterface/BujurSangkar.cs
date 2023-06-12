class BujurSangkar : BangunDatar, ILuasBangunDatar
{
    private double sisi;

    public BujurSangkar(double sisi)
    {
        this.sisi = sisi;
    }

    public override double HitungLuas()
    {
        return sisi * sisi;
    }
}