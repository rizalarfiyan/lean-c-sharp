class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("================= List Nilai =================");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        List<int> listNilai = new List<int>();

        listNilai.Add(70);
        listNilai.Add(100);
        listNilai.Add(85);

        int nilaiElement1 = listNilai[1];
        Console.WriteLine(nilaiElement1);
        Console.WriteLine();

        foreach (int nilai in listNilai)
        {
            Console.WriteLine(nilai);
        }

        Console.WriteLine("==============================================");
        Console.WriteLine("================== List Nama =================");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nim = "1234";
        mhs1.Nama = "Erik";

        Mahasiswa mhs2 = new Mahasiswa();
        mhs2.Nim = "1235";
        mhs2.Nama = "weli";

        Dosen dosen = new Dosen();
        dosen.Nik = "0034";
        dosen.Nama = "Jhonoo";

        List<Mahasiswa> listMhs = new List<Mahasiswa>();
        listMhs.Add(mhs1);
        listMhs.Add(mhs2);

        Mahasiswa mhs = listMhs[1];
        Console.WriteLine("{0} {1}", mhs.Nim, mhs.Nama);

        Console.WriteLine("==============================================");
        Console.WriteLine("============ List Nama Mahasiswa =============");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        Console.WriteLine("Nim\t\t Nama");
        Console.WriteLine("===========================");
        foreach (Mahasiswa mhsItem in listMhs)
        {
            Console.WriteLine("{0} \t\t {1}", mhsItem.Nim, mhsItem.Nama);
        }

        Console.ReadKey();
    }
}