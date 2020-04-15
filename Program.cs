using System;

namespace responsipemrograman2887
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(182012, "sulfikar", 500000);
            Karyawan karyawan2 = new Karyawan(182013, "hartono", 200000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Asique naik gaji nih");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }
}