namespace DataMahasiswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa("John Doe", 22104114, "Teknik Informatika", 2022);
            Mahasiswa mhs2 = new Mahasiswa("Jane Doe", 220711241, "Sistem Informasi", 2022);
            Mahasiswa mhs3 = new Mahasiswa("Muhamad Rizal Arfiyan", 22115227, "S1 Informatika", 2022);

            mhs1.PrintInfo();
            mhs2.PrintInfo();
            mhs3.PrintInfo();

            Console.ReadKey();
        }
    }
}
