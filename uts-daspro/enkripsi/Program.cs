using System;
using System.Text.RegularExpressions;


namespace enkripsi {
    class Program {
        static void Main(string[] args) {

            Regex filter = new Regex("[^A-Za-z ]");
            String text;

            do {
                Console.Clear();
                Console.Write("Teks : ");
                text = Console.ReadLine();
            } while (String.IsNullOrEmpty(text) || filter.IsMatch(text));

            Console.WriteLine($"Hasil Enkripsi : {en(text)}");

        }

        static string en(string text) {

            String var = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCabcdefghijklmnopqrstuvwxyzabc";
            string eng = "";

            foreach(Char O in text) {
                Char temp = ' ';
                for (int i = 0; i < var.Length; i++) {
                    Char c = var[i];
                    if (O.Equals(c)) {
                        temp = var[i + 3];
                        break;
                    } else if (O.Equals(' ')) {
                        temp = ' ';
                        break;
                    }
                }
                eng += temp;
            }
            
            return eng;
        }

    }
}