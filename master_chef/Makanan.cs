namespace master_chef
{
    class Makanan
    {
        protected string bahanUtama;

        public Makanan(string bahanUtama)
        {
            this.bahanUtama = bahanUtama;
        }

        public virtual string Resep()
        {
            return "Ini adalah resep makanan.";
        }

        public virtual void PerisapanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bagan utama.");
        }

        public static void PanaskanOven(int suhu)
        {
            Console.WriteLine($"Panashkan even pada suhu {suhu} derajat Celcious.");
        }
    }
}
