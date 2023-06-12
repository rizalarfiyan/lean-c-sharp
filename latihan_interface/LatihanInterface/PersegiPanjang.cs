class PersegiPanjang : BangunDatar, ILuasBangunDatar
{
    private double panjang;
    private double lebar;

    public PersegiPanjang(double panjang, double lebar)
    {
        this.panjang = panjang;
        this.lebar = lebar;
    }

    public override double HitungLuas()
    {
        return panjang * lebar;
    }
}