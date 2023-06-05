class Epson: PrinterWindows
{
    // Default function Show()
    public override void Show()
    {
        Console.WriteLine("Epson display dimension: 10*11");
    }

    // Default function Print()
    public override void Print()
    {
        Console.WriteLine("Epson printing....");
    }
}