namespace master_chef
{
    class Pasta : Makanan
    {
        private string bentuk;

        public Pasta(string bahanUtama, string bentuk) : base(bahanUtama)
        {
            this.bentuk = bentuk;
        }

        public override string Resep()
        {
            return "Ini adalah resep pasta.";
        }

        public void Rebus(int waktu)
        {
            Console.WriteLine($"Rebus {bentuk} selama {waktu} menit.");
        }

        public override void PerisapanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"Bentuk {bahanUtama} menjadi {bentuk}.");
        }
    }
}
