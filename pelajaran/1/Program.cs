/*
   code dibuat oleh Mohd. Abulkhairi Labib
*/

// menggunakan library System 
using System;

namespace _1 {
    class Program {

        /*
         main method
        */
        static void Main(string[] args) {

            // deklarasi
            const int a = 5;
            const int b = 4;
            const int c = 7;
            int tambah,kali,minus;
            double bagi;

            // Arithmetic operators   
              // penjumlahan
                 tambah = a + b + c;
              // pengurangan
                 minus = a + b + c;
              // perkalian
                 kali = a + b + c;
              // pembagian
                 bagi = a / b / c;


            // menuliskan Narasi 
            // console adalah function atau class dari system
            Console.WriteLine("Anda adalah agen rahasia bertugas mendapatkan data dari server");
            Console.WriteLine("Akses keserver membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + tambah);
            Console.WriteLine("- Jika dikurangkan hasilnya " + minus);
            Console.WriteLine("- Jika dikalikan hasilnya " + kali);
            Console.WriteLine("- Jika dibagikan hasilnya " + bagi);
            Console.WriteLine("\n");
            Console.WriteLine("Enter code : ");
        }
    }
}