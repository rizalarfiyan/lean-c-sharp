using System.ComponentModel;

class BangunDatar: ILuasBangunDatar
{
    public virtual double HitungLuas()
    {
        return 0.0;
    }

    public void Result()
    {
        Console.WriteLine("Luas: " + this.HitungLuas());
    }
}