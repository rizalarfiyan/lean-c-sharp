namespace master_chef
{
    class MiePasta : Makanan
    {
        private string rasa;
        private string bentuk;

        public MiePasta(string bahanUtama, string rasa, string bentuk) : base(bahanUtama)
        {
            this.bentuk = bentuk;
            this.rasa = rasa;
        }

        public override string Resep()
        {
            return "Ini adalah resep mie pasta.";
        }

        public void Rebus(int waktu)
        {
            Console.WriteLine($"Rebus {bentuk} selama {waktu} menit.");
        }

        public override void PerisapanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"Bentuk {bahanUtama} menjadi {bentuk}.");
            Console.WriteLine($"Tambahkan bumbu {rasa} ke dalam air rebusan mie pasta.");
        }
    }
}
