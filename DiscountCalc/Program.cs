using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalc
{
    /// <summary>
    /// kelas Discount
    /// </summary>
    /// <remarks>kelas Discount sebagai kelas untuk mewadahi perhitungan diskon dan nilai nantinya</remarks>

    public class Discount
    {
        public decimal hargaAsli;
        public double diskon;
        public decimal penguranganHarga;
        public decimal hargaDiskon;

        /// <summary>
        /// method konstruktor Discount
        /// </summary>
        /// <remarks>dijalankan saat kelas Discount dipanggil , serta memasukkan parameter hargaAsli dan diskon ke attribute kelas Discount, dan memanggil method HitungDiskon</remarks>
        /// <param name="pHargaAsli">paramater pHargaAsli untuk diterima dan dimasukkan ke hargaAsli</param>
        /// <param name="pDiskon">paramater pDiskon untuk diterima dan dimasukkan ke diskon</param>
        /// <returns>tidak menghasilkan return , karena berupa konstruktor</returns>

        public Discount(decimal pHargaAsli, double pDiskon)
        {
            hargaAsli = pHargaAsli;
            diskon = pDiskon;

            HitungDiskon();
        }

        /// <summary>
        /// method HitungDiskon
        /// </summary>
        /// <remarks>digunakan untuk menghitung berapa pengurangan harga , dan harga setelah diskon</remarks>
        /// <returns>tidak menghasilkan return , karena berupa void dan nilai langsung disimpan ke attribute</returns>
        private void HitungDiskon()
        {
            penguranganHarga = ( hargaAsli * (decimal)diskon) / 100;
            hargaDiskon = hargaAsli - penguranganHarga;
        }
    }

    /// <summary>
    /// kelas Program
    /// </summary>
    /// <remarks>kelas yang berisi method utama yang dijalankan saat program dijalankan</remarks>
    class Program
    {
        /// <summary>
        /// method Main
        /// </summary>
        /// <remarks>Method utama yang dijalankan saat program dijalankan</remarks>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("====== Aplikasi Sederhana Perhitungan Diskon =========");
            Console.WriteLine("======================================================");
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("");
                Console.Write("Masukkan harga asli = ");
                decimal hargaAsli = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukkan diskon(%) = ");
                double diskon = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");

                Discount discount = new Discount(hargaAsli, diskon);

                Console.WriteLine("Hasil perhitungan diskon : ");
                Console.WriteLine("- Harga Asli = "+hargaAsli);
                Console.WriteLine("- Diskon = "+diskon+"%");
                Console.WriteLine("- Pengurangan Harga = "+discount.penguranganHarga);
                Console.WriteLine("- Harga Setelah Diskon = " + discount.hargaDiskon);
                Console.WriteLine("");
                Console.WriteLine("======================================================");
                Console.WriteLine("");

                bool? isChoiceValid = null;
                while (!((isChoiceValid == null ? false : true)) || (isChoiceValid == false))
                {
                    if (isChoiceValid == false)
                    {
                        Console.WriteLine("Perintah tidak dapat ditemukan ! pilih antara y/n");
                    }

                    Console.Write("Apakah anda ingin hitung diskon lagi ? (y/n) = ");
                    String choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "y":
                            isChoiceValid = true;
                            break;
                        case "n":
                            isChoiceValid = true;
                            isContinue = false;
                            break;
                        default:
                            isChoiceValid = false;
                            break;
                    }
                }
                
            }
            

        }
    }
}
