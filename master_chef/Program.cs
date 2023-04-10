namespace master_chef
{
    class Progams
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di dapur!");
            Console.WriteLine("Apa yang ingin Anda masak?");
            Console.WriteLine("1. Membuat roti");
            Console.WriteLine("2. Membuat pasta");
            Console.WriteLine("3. Membuat mie");
            Console.WriteLine("4. Membuat mie pasta");

            Console.Write("Pilih menu: ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Roti roti = new Roti("tepung", 60);
                    roti.PerisapanBahan();
                    Makanan.PanaskanOven(180);
                    roti.Panggang(20);
                    Console.WriteLine(roti.Resep());
                    break;
                case 2:
                    Pasta pasta = new Pasta("spagetti", "linguine");
                    pasta.PerisapanBahan();
                    pasta.Rebus(8);
                    Console.WriteLine(pasta.Resep());
                    break;
                case 3:
                    Mie mie = new Mie("mie instan", "rendang");
                    mie.PerisapanBahan();
                    mie.Rebus(3);
                    Console.WriteLine(mie.Resep());
                    break;
                case 4:
                    MiePasta miePasta= new MiePasta("mie spagetti", "barbeque", "linguine");
                    miePasta.PerisapanBahan();
                    miePasta.Rebus(3);
                    Console.WriteLine(miePasta.Resep());
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    break;
            }

            Console.WriteLine("Selamat menikmati");
        }
    }
}