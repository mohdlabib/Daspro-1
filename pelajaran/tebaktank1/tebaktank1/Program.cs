/*
  Nama : Mohd. Abulkhairi Labib
  class : TI B
*/
using System;

namespace tebaktank1 {
    class Program {
        static void Main(string[] args) {
            try {
                int Stank = 3, tankH = Stank, DessertLength = 5;
                char tank = 'T',sand = '~',hit = 'X',miss = 'O',boom = 'x';

                // array
                char[, ] Dessert = createDessert(DessertLength, sand, tank, Stank);

                Console.Clear();
                Console.WriteLine(
                    " GAME Tembak Tank \n Terdapat 3 tank dan anda harus menembaknya \n dengan cara menentukan coordinatnya \n"
                );

                printD(Dessert, sand, tank, boom);

                // loop
                while (tankH > 0) {
                    int[] guessCoordinates = CoordinateUser(DessertLength);
                    char locationViewUpdate = target(guessCoordinates, Dessert, tank, sand, hit, miss, boom);

                    if (locationViewUpdate == hit) {
                        tankH--;
                    }
                    Dessert = updateDessert(Dessert, guessCoordinates, locationViewUpdate);
                    Console.WriteLine("total Tank :" + tankH);
                    printD(Dessert, sand, tank, boom);
                }
            } catch (System.FormatException) {
                Console.WriteLine(" tolong input angka saja");
            }
        }

        static void printD(char[, ] Dessert, char sand, char tank, char boom) {
            Console.Write("  ");
            for (int i = 0; i < 5; i++) {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
            for (int row = 0; row < 5; row++) {
                Console.Write(row + 1 + " ");
                for (int coloumn = 0; coloumn < 5; coloumn++) {
                    char position = Dessert[row, coloumn];
                    if (position == tank) {
                        Console.Write(sand + " ");
                    } else {
                        Console.Write(position + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static int[] generatecoordinat(int DessertLength) {
            Random r = new Random();
            int[] coordinates = new int[2];
            for (int i = 0; i < coordinates.Length; i++) {
                coordinates[i] = r.Next(DessertLength);
            }
            return coordinates;
        }

        static char target(int[] guessCoordinates, char[, ] Dessert, char tank, char sand, char hit, char miss, char boom) {
            string message;
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            char target = Dessert[row, coloumn];

            if (target == tank) {
                message = " \nBerhasil menembak tank\n";
                target = hit;
            } else if (target == sand) {
                message = " \nGagal, coba lagi\n";
                target = miss;
            } else if (target == hit) {
                message = " \ntank telah ditembak ";
                target = boom;
            } else {
                message = " \nArea ini bersih\n ";
            }
            
            Console.Clear();
            Console.WriteLine(message);
            return target;
        }

        static char[, ] updateDessert(char[, ] Dessert, int[] guessCoordinates, char locationViewUpdate) {
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            Dessert[row, coloumn] = locationViewUpdate;
            return Dessert;
        }

        static int[] CoordinateUser(int DessertLength) {
            int row;
            int col;

            do {
                Console.Write("\n posisi x : ");
                row = Convert.ToInt32(Console.ReadLine());
            }
            while (row < 0 || row > DessertLength + 1);

            do {
                Console.Write(" posisi Y: ");
                col = Convert.ToInt32(Console.ReadLine());
            }
            while (col < 0 || col > DessertLength + 1);
            return new [] {
                row - 1, col - 1
            };
        }

        static char[, ] placeTanks(char[, ] Dessert, int Stank, char sand, char tank) {
            int DessertLength = 5;
            int tankPlaced = 0;

            while (tankPlaced < Stank) {
                int[] tankLocation = generatecoordinat(DessertLength);
                char positionOK = Dessert[tankLocation[0], tankLocation[1]];


                if (positionOK == sand) {
                    Dessert[tankLocation[0], tankLocation[1]] = tank;
                    tankPlaced++;
                }
            }
            return Dessert;
        }

        static char[, ] createDessert(int DessertLength, char sand, char tank, int Stank) {
            char[, ] Dessert = new char[DessertLength, DessertLength];
            for (int row = 0; row < DessertLength; row++) {
                for (int coloumn = 0; coloumn < DessertLength; coloumn++) {
                    Dessert[row, coloumn] = sand;
                }
            }
            return placeTanks(Dessert, Stank, sand, tank);
        }
    }
}