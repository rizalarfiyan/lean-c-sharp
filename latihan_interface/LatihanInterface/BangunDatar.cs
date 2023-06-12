using System.ComponentModel;

class BangunDatar
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