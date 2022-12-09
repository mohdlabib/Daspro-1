using System;

namespace Tibioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int year;

            try {

                Console.Clear();
                Console.WriteLine("Nama :");
                name = Console.ReadLine();

                Console.WriteLine("Tahun :");
                year = Convert.ToInt32(Console.ReadLine());

                printTicket(name,year);


            } catch (System.FormatException) 
            {
                Console.WriteLine("Salah type input!");
            } catch(System.Exception)
            {
                Console.WriteLine(" Maaf ada kesalahan ");
            }
        }

        static void printTicket(string nama, int year){

            int space = nama.Length + 4;
            Console.WriteLine($"\n|{b(nama,'*')}|");     
            Console.WriteLine("{0} {1, "+ (space - 2)+"}", "|      --Studio 1--", "|");
            Console.WriteLine("{0} {1, "+ (space + 11) +"}", "|Nama:", $"{nama}|");
            Console.WriteLine("{0} {1, "+ (space + 5) +"}", "|Harga:   Rp", $"{price(year)}.00|");
            Console.WriteLine($"|{b(nama,'-')}|");   
            
        }

        static string b(string value, char a){
            string x = "";

            for (int i = 0; i < value.Length + 20; i++){
               x = x + a;
            }

            return x;
        }

        static int price(int year){

            var today = DateTime.Today;
            var age = today.Year - year;

            if(age < 10 || age > 60){
                return 10000;
            } else {
                return 25000;
            }
        }
    }
}
