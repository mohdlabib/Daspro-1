using System;
using System.Collections.Generic;


namespace _5 {
    class Program {
        static List < string > KT = new List < string > ();

        static void Main(string[] args) {

            string misteri = "samsul";
            string x = "";

            while (true) {
                string input = Console.ReadLine();
                KT.Add(input);

                for (int i = 0; i < misteri.Length; i++) {
                    string c = Convert.ToString(misteri[i]);
                    if (KT.Contains(c)) {
                        x = x + c;
                    } else {
                        x = x + "_";
                    }
                }

              Console.Write(x + "\n");

            }


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
    }
}