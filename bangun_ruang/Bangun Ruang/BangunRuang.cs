abstract class BangunRuang: IBangunRuang
{
    public abstract double hitungVolume();
    public abstract double hitungLuasPermukaan();
    public abstract void printInput();

    public virtual void print()
    {
        Console.WriteLine();
        printInput();
        Console.WriteLine();
        Console.WriteLine("Hasil kalkulasi:");
        Console.WriteLine("Volume: {0}", hitungVolume());
        Console.WriteLine("Luas permukaan: {0}", hitungLuasPermukaan());
        Console.WriteLine("============================================================");
    }
}