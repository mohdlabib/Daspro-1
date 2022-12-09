using System;

namespace nametag {
    class Program {
        static void Main(string[] args) {

            String nama, konsentrasi, nim;

            try {

                Console.Clear();
                Console.WriteLine("Nama :");
                nama = Console.ReadLine();

                Console.WriteLine("Nim :");
                nim = Console.ReadLine();

                Console.WriteLine("Konsentrasi : (RPL/KCV/Jaringan)");
                konsentrasi = Console.ReadLine();

                printTag(nama,nim,konsentrasi);


            } catch (System.FormatException) 
            {
                Console.WriteLine("salah input lah");
            }  catch(System.Exception)
            {
                Console.WriteLine("Maaf ada kesalahan ");
            }
        }

        static void printTag(string nama, string nim, string konsentrasi){

            int space = nama.Length + 15;
            Console.WriteLine($"\n|{b(nama,'*')}|");     
            Console.WriteLine($"|Nama:          {nama}|");
            Console.WriteLine("{0} {1, "+space+"}", "|", $"{nim}|");
            Console.WriteLine($"|{b(nama,'-')}|");     
            Console.WriteLine("{0} {1, "+space+"}", "|", $"{konsentrasi}|");
            Console.WriteLine($"|{b(nama,'*')}|");     

        }

        static string b(string value, char a){
            string x = "";

            for (int i = 0; i < value.Length + 15; i++){
               x = x + a;
            }

            return x;
        }
    }
}