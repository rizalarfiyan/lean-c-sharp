namespace master_chef
{
    class Roti: Makanan
    {
        private int kadarAir;

        public Roti(string bahanUtama, int kadarAir) : base(bahanUtama)
        {
            this.kadarAir = kadarAir;
        }

        public override string Resep()
        {
            return "Ini adalah resep roti.";
        }

        public void Panggang(int waktu)
        {
            Console.WriteLine($"Panggang roti selama {waktu} menit.");
        }

        public override void PerisapanBahan()
        {
            Console.WriteLine($"Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"Tambahkan air dengan kadar {kadarAir} persen.");
        }
    }
}
