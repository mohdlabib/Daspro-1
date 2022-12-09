using System;
using System.Collections.Generic;


namespace hangman {
    class Program {

        static int kesempatan = 0;
        static string kataMisteri = "informatika";
        static List < string > ListTebakan = new List < string > {};

        static void Main(string[] args) {
            Console.Clear();

            try
            { 
              PlayGame();
            } catch(System.FormatException)
            {
                Console.WriteLine("type input anda salah");
            } catch(System.Exception)
            {
                Console.WriteLine("Maaf ada kesalahan ");
            }
        }

        static void PlayGame() {
            while (kesempatan < 10) {

                Console.Write("Huruf Tebakan: ");

                string input = Console.ReadLine();
                ListTebakan.Add(input);

                Console.Clear();

                if (cekJawaban(kataMisteri, ListTebakan)) {
                    Console.WriteLine();
                    printhangman(kesempatan);
                    Console.WriteLine("Selamat, Anda menang!");
                    break;

                } else if (kataMisteri.Contains(input)) {
                    Console.WriteLine(cekHuruf(kataMisteri, ListTebakan));
                    Console.WriteLine();
                    printhangman(kesempatan);
                } else {
                    Console.WriteLine("Tebakan anda salah.");
                    Console.WriteLine(cekHuruf(kataMisteri, ListTebakan));
                    kesempatan++;
                    Console.WriteLine();
                    printhangman(kesempatan);
                }
            }
        }

        static bool cekJawaban(string text, List < string > List) {
            bool om = false;
            for (int i = 0; i < text.Length; i++) {
                string str = Convert.ToString(text[i]);
                if (List.Contains(str)) {
                    om = true;
                } else {
                    return om = false;
                }

            }
            return om;
        }

        static string cekHuruf(string text, List < string > List) {
            string var = "";
            for (int i = 0; i < text.Length; i++) {
                string str = Convert.ToString(text[i]);
                if (List.Contains(str)) {
                    var += str;
                } else {
                    var += "_";
                }

            }
            return var;
        }

        static void printhangman(int wrong){
            if (wrong == 1)
            {
                Console.WriteLine("_|___");
            }
            else if (wrong == 2)
            {
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 3)
            {
                Console.WriteLine(" |/");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/      |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/      |");
                Console.WriteLine(" |      (_)");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 7)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/      |");
                Console.WriteLine(" |      (_)");
                Console.WriteLine(" |      \\|/");
                Console.WriteLine(" |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 8)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/      |");
                Console.WriteLine(" |      (_)");
                Console.WriteLine(" |      \\|/");
                Console.WriteLine(" |       |");
                Console.WriteLine(" |");
                Console.WriteLine("_|___");
            }
            else if (wrong == 9)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/      |");
                Console.WriteLine(" |      (_)");
                Console.WriteLine(" |      \\|/");
                Console.WriteLine(" |       |");
                Console.WriteLine(" |      / \\");
                Console.WriteLine("_|___");
            }
            else if (wrong == 10)
            {
                Console.WriteLine("__________");
                Console.WriteLine(" |/      |");
                Console.WriteLine(" |      (_)");
                Console.WriteLine(" |      \\|/");
                Console.WriteLine(" |       |");
                Console.WriteLine(" |      / \\");
                Console.WriteLine("_|___");
                Console.WriteLine("Anda Kurang Beruntung");
            }
        }
    }
}