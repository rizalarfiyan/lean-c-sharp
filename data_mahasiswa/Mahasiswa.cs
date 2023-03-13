namespace DataMahasiswa
{
    internal class Mahasiswa
    {

        // properties
        public string Nama { get; set; }
        public int NIM { get; set; }
        public string Jurusan { get; set; }
        public int Angkatan { get; set; }

        // constructor
        public Mahasiswa(string nama, int nim, string jurusan, int angkatan)
        {
            Nama = nama;
            NIM = nim;
            Jurusan = jurusan;
            Angkatan = angkatan;
        }

        // method
        public void PrintInfo()
        {
            Console.WriteLine("Nama\t\t: " + Nama);
            Console.WriteLine("NIM\t\t: " + NIM);
            Console.WriteLine("Jurusan\t\t: " + Jurusan);
            Console.WriteLine("Angkatan\t: " + Angkatan);
            Console.WriteLine();
        }
    }
}