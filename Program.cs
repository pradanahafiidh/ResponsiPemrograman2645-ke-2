using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        Console.WriteLine("\nTekan enter untuk kembali ke menu");
                        Console.ReadKey();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection

            Console.WriteLine("Tambah Data Produk");
            Console.Write("Kode Produk\t: ");
            double _kode = double.Parse(Console.ReadLine());
            Console.Write("Nama Produk\t: ");
            string _nama = Console.ReadLine();
            Console.Write("Harga Beli\t: ");
            double _beli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual\t: ");
            double _jual = double.Parse(Console.ReadLine());

            _produk(_kode,_nama,_beli,_jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();
            TampilProduk();
            Console.WriteLine("\n");
            Console.Write("Masukan Kode Produk : ");
            double _pilKode = double.Parse(Console.ReadLine());
            bool chek = false;
            for(int i =0; i < daftarProduk.Count; i++)
            {
                if(daftarProduk[i].Kode == _pilKode)
                {
                    var hapus = daftarProduk.Single(r => r.Kode == _pilKode);
                    Console.WriteLine("Data berhasil ditemukan...");
                    Console.WriteLine("Kode\t\t: " + hapus.Kode);
                    Console.WriteLine("Nama\t\t: " + hapus.Nama);
                    Console.WriteLine("Harga Jual\t: " + hapus.Jual);
                    Console.WriteLine("Harga Beli\t: " + hapus.Beli);

                    //daftarProduk.Remove(hapus);
                    //chek = true;
                    Console.Write("Yakin ingin menghapus data??[y/n] : ");
                    char lanjut = char.Parse(Console.ReadLine());
                    if (lanjut == 'y' || lanjut == 'Y')
                    {
                        daftarProduk.Remove(hapus);
                        Console.WriteLine("Data berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data");
                    }
                    chek = true;
                }
                if(!chek)
                {
                    Console.WriteLine("Maaf, Kode tidak ditemukan");
                }
            }
            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int nomorUrut = 1;
            foreach(Produk produk in daftarProduk)
            {
                Console.WriteLine("NO.{0}" + " " + "Kode.{1}" + "\t" + "Nama : {2}" + "\t"+"Hagra Jual : {3}"+"\t"+"Harga Beli : {4}",
                     nomorUrut,produk.Kode,produk.Nama,produk.Jual,produk.Beli);
                nomorUrut++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
        }

        static void _produk(double _kode, string _nama, double _beli,double _jual)
        {
            daftarProduk.Add(new Produk {Kode = _kode,Nama = _nama,Jual = _jual,Beli = _beli });
        }
    }
}
