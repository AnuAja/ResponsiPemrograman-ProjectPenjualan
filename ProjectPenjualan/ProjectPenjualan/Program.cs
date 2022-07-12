using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.Clear();
            Console.WriteLine("Pilih Menu Di Bawah Ini : ");
            Console.WriteLine(" 1. Tambah Penjualan");
            Console.WriteLine(" 2. Tampilkan Penjualan");
            Console.WriteLine(" 3. Keluar");
        }

        static void TambahPenjualan()
        {
            Penjualan penjualan = new Penjualan();
            Console.Clear();
            Console.WriteLine("Tambah Penjualan : \n");

            Console.Write("Nota : ");
            penjualan.Nota = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal : ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Customer : ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis (T/K) : ");
            string jenis = Console.ReadLine();
     
               penjualan.Jenis = (jenis == "T" || jenis == "t") ? "Tunai" : "Kredit";

            Console.Write("Total Nota : ");
               penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan \n");
            if (daftarPenjualan.Count > 0)
            { 
                int no = 0;
                Console.WriteLine("Data Penjualan");
                foreach (Penjualan penjualan in daftarPenjualan)
                {
                    no++;
                    Console.WriteLine(no + ". " + penjualan.Nota + ", " + penjualan.Tanggal + ", " + penjualan.Customer + ", " + penjualan.Jenis + ", " + penjualan.TotalNota);
                }
            }
            else
            {
                Console.WriteLine("TIDAK ADA DAFTAR PENJUALAN !!!");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
