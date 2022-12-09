/*
  Nama : Mohd. Abulkhairi Labib
  Nim : 2207125064

  Mohon maaf Pak, jika saya memandai-mandai pak 🙏
*/
using System;
using Spectre.Console;

namespace _2 {
    class Program {

        // mendekralasi variable
        static int codeA, codeB, codeC, plus, kali, minus, kesempatan = 3;
        static int choiceA, choiceB, choiceC, level = 1, random = 3;
        static Random rnd = new Random();
        static double bagi;
        static bool cancel = false;

        // function utama atau Main
        static void Main(string[] args) {

            // menggubah Encoding
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
         
            start();

            // choice
            var play = AnsiConsole.Prompt(
                new SelectionPrompt < string > ()
                .AddChoices(new [] {
                    "Masuk",
                    "Exit",
                }));

            // play
                while (play == "Masuk") {
                    playG();
                    if (cancel == true) {
                        break;
                    }
                }

        }

        static void playG() {

            // random
            codeA = rand(random);
            codeB = rand(random);
            codeC = rand(random);

            // Arithmetic operators   
              // penjumlahan
                 plus = codeA + codeB + codeC;
              // pengurangan
                 minus = codeA - codeB - codeC;
              // perkalian
                 kali = codeA * codeB * codeC;

            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("Server KGB")
                .LeftAligned()
                .Color(Color.Red)
            );

            AnsiConsole.Markup(
                $"\t[yellow]Level {level}[/] \t|\t {heart(kesempatan)} \n\n" +
                " Kode terdiri [darkorange]dari[/] 3 angka yang acak\n"
            );

            // Membuat table
            var table = new Table();
            table.Border(TableBorder.Rounded);

            // menambahkan colum
            table.AddColumn("Petunjuk");
            table.AddColumn(new TableColumn("Jawaban").Centered());

            // menambahkan row
            table.AddRow("Jika ditambahkan hasilnya", $"{plus}");
            table.AddRow("Jika dikurangkan hasilnya", $"{minus}");
            table.AddRow("Jika dikalikan hasilnya", $"{kali}");
            AnsiConsole.Write(table);


            // tebakan pertama
            choiceA = AnsiConsole.Prompt(
            new TextPrompt<int>("Masukan [green]tebakan[/] pertama ?")
                .PromptStyle("green")
                .ValidationErrorMessage("[red]Tolong hanya input angka![/]")
            );

            // tebakan kedua
            choiceB = AnsiConsole.Prompt(
            new TextPrompt<int>("Masukan [darkorange]tebakan[/] kedua ?")
                .PromptStyle("darkorange")
                .ValidationErrorMessage("[red]Tolong hanya input angka![/]")
            );

            // tebakan ketiga
            choiceC = AnsiConsole.Prompt(
            new TextPrompt<int>("Masukan [yellow]tebakan[/] ketiga ?")
                .PromptStyle("yellow")
                .ValidationErrorMessage("[red]Tolong hanya input angka![/]")
            );

            if(choiceA == codeA && choiceB == codeB && choiceC == codeC){
                success();
            } else {
                failed();
            }

        }

        static void start() {
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("Server KGB")
                .LeftAligned()
                .Color(Color.Red)
            );

            AnsiConsole.Markup(
                "[lime]Anda[/] adalah [red]Agen rahasia[/] bertugas mendapatkan [lime]data[/] dari [yellow]server[/]\n" +
                "dengan [lime]cara[/] memecahkan beberapa kode [red]rahasia[/] dengan kesusahan yang terus bertambah\n" +
                "dan anda hanya memiliki [yellow]3[/] kesempatan untuk itu.\n\n"
            );
        }

        static void success(){
            AnsiConsole.Clear();

            level = level + 1;
            random = random + 2;
            string play;

            // choice
            if(level > 5){
                AnsiConsole.Write(
                    new FigletText("Selamat")
                    .LeftAligned()
                    .Color(Color.Green)
                );

                AnsiConsole.Markup(
                  " [lime]Selamat[/] anda telah [yellow]memecahkan[/] kode [lime]rahasia[/] \n" +
                  " anda [yellow]the best[/] :clapping_hands:\n\n" +
                  " [blue]> Exit[/]"
                ); 

                play = "Exit";  
            } else {
                AnsiConsole.Write(
                    new FigletText("Berhasil")
                    .LeftAligned()
                    .Color(Color.Green)
                );

                AnsiConsole.Markup(
                  $" Tebakan anda [lime]benar[/] anda akan dialikan ke [yellow]level {level}[/]\n\n" 
                );

                play = AnsiConsole.Prompt(
                new SelectionPrompt < string > ()
                    .AddChoices(new [] {
                        "Next level",
                        "Exit",
                }));  
            }


            if(play == "Exit"){
               cancel = true;
            } 
        }

        static void failed(){
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("GAGAL")
                .LeftAligned()
                .Color(Color.Red)
            );  

            kesempatan = kesempatan - 1;
            string play;

            // choice
            if(kesempatan < 1){
                AnsiConsole.Markup(
                  " [green]tebakan[/] anda salah [orange1]kesempatan[/] anda telah [red]habis[/]\n" +
                  " Server akan otomatis [red]terputus[/]\n\n" +
                  " [blue]> Exit[/]"
                ); 

                play = "Exit";  
            } else {
                AnsiConsole.Markup(
                  $" [green]tebakan[/] anda salah [orange1]kesempatan[/] anda tinggal [red]{kesempatan}[/]\n\n" 
                );

                play = AnsiConsole.Prompt(
                new SelectionPrompt < string > ()
                    .AddChoices(new [] {
                        "Coba Lagi",
                        "Exit",
                }));  
            }


            if(play == "Exit"){
               cancel = true;
            }                                                                                                                              
        }

       // function random
        static int rand(int level) {
            return rnd.Next(0, level);
        }

        // function heart
        static string heart(int heart){
            string hearts;
            switch(heart) 
                {
                case 1:
                    hearts = "[red]:red_heart:[/]";
                    break;
                case 2:
                    hearts = "[red]:red_heart: :red_heart:[/]";
                    break;
                case 3:
                    hearts = "[red]:red_heart: :red_heart: :red_heart:[/]";
                    break;
                default:
                    hearts = "[yellow]:red_heart:[/]";
                    break;
                }
            return hearts;
        }

    }
}