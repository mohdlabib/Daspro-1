using System;

namespace kursUSD {
    class Program {
        static void Main(string[] args) {

            double usd = 15356.70;
            int idr;

            try {
                
                Console.Clear();
                Console.WriteLine("Rate USD ke IDR");
                Console.WriteLine(usd);

                Console.WriteLine("Jumlah USD:");
                idr = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Hasil Konversi: {kurs(usd,idr)}");

            } catch (System.FormatException) 
            {
                Console.WriteLine("Tidak bisa memasukan selain angka");
            } catch(System.Exception)
            {
                Console.WriteLine(" Maaf ada kesalahan");
            }
        }

        static double kurs(double usd, int idr) {
            return usd * idr;
        }
    }
}