/*
  Nama : Mohd. Abulkhairi Labib
  Nim : 2207125064

*/
using System;
using System.Collections.Generic;

namespace _4 {
    class Program {
        static int kesempatan = 5;
        static String misteri;
        static Random rand = new Random();
        static List<string> listtebakan = new List<string>();

        static void Main(string[] args) {
            random();
            intro();
            playGame();
        }

        static void intro() {
            Console.WriteLine($"tebak kata acak dan kamu hanya punya kesempatan {kesempatan}x");
            Console.WriteLine($"untuk menebaknya, kata terdiri atas {misteri.Length} huruf");
            Console.ReadLine();
        }

        static void playGame() {
            while (kesempatan > 0) {
                Console.WriteLine($"tebak Katanya");
                string input = Console.ReadLine();
                listtebakan.Add(input);

                if (cekjawaban(misteri, listtebakan)) {
                    Console.WriteLine($"tebak huruf {misteri}");
                    break;
                } else if (misteri.Contains(input)) {
                    Console.WriteLine("huruf ada");
                    Console.WriteLine(cekhuruf(misteri, listtebakan));
                } else {
                    Console.WriteLine("tebakan salah");
                    kesempatan--;
                    Console.WriteLine($"kesempatan tinggal {kesempatan}x");
                }

                if (kesempatan == 0) {
                    endGame();
                    break;
                }

            }
        }

        static bool cekjawaban(string misteri, List < string > list) {
            bool status = false;

            for (int i = 0; i < misteri.Length; i++) {
                string c = Convert.ToString(misteri[i]);
                if (list.Contains(c)) {
                    status = true;
                } else {
                    status = false;
                }
            }

            return status;
        }

        static string cekhuruf(string misteri, List < string > list) {
            string x = "";

            for (int i = 0; i < misteri.Length; i++) {
                string c = Convert.ToString(misteri[i]);
                if (list.Contains(c)) {
                    x = x + c;
                } else {
                    x = x + "_";
                }
            }

            return x;
        }

        static void endGame() {
            Console.WriteLine("berakhir");
            Console.WriteLine($"kata {misteri}");
            Console.WriteLine("bye...");
        }

         // functions rand
        static void random() {

            var fb = new string[] {
                "Manchester City",
                "Liverpool",
                "Chelsea",
                "Tottenham",
                "Arsenal",
                "Manchester United",
                "West Ham",
                "Wolverhampton",
                "Leicester City",
                "Brighton",
                "HoveBrentford",
                "Newcastle",
                "Crystal Palace",
                "Aston Villa",
                "Southampton",
                "Everton",
                "Leeds United",
                "Burnley",
                "WatfordNorwich",
                "Atletico Madrid",
                "Barcelona",
                "Real Madrid",
                "PSG",
                "Bayern Munich",
                "Juventus"
            };

            misteri = fb[rand.Next(0, fb.Length)];
            misteri = misteri.ToLower();
        }
    }
}