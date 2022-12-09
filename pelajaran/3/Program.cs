/*
  Nama : Mohd. Abulkhairi Labib
  Nim : 2207125064

*/
using System;
using Spectre.Console;

namespace _2 {
    class Program {

        // mendekralasi variable
        static int pcN, daduH, level = 1, random = 7, win, lose;
        static Random rnd = new Random();
        static bool cancel = false;

        // function utama atau Main
        static void Main(string[] args) {

            // menggubah Encoding
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            start();

            // choice
            var play = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
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
            pcN = rand(random);
            daduH = rand(random);

            if (level >= 11) {
                over();
            } else {
                if (daduH > pcN) {
                    success();
                } else if (daduH == pcN) {
                    draw();
                } else {
                    failed();
                }
            }

        }

        static void start() {
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("Game Dadu")
                .LeftAligned()
                .Color(Color.Blue)
            );

            AnsiConsole.Markup(
                "Ini adalah [lime]permainan dadu[/] :game_die: antara [green]anda[/] :man: dan [yellow]komputer :robot:[/] dengan [orangered1]10x permainan[/]\n\n"
            );
        }

        static void success() {
            AnsiConsole.Clear();

            level = level + 1;
            win = win + 1;
            string play;

            // choice
            AnsiConsole.Write(
                new FigletText("Anda Menang")
                .LeftAligned()
                .Color(Color.Green)
            );

            AnsiConsole.Markup(
                $" [lime]Angka[/] dadu anda [darkorange]lebih besar[/] dari [red]pc[/]\n" +
                $" - skor [green]anda {win}[/] \n" +
                $" - skor [red]pc {lose}[/] \n\n"
            );

            play = AnsiConsole.Prompt(
                new SelectionPrompt < string > ()
                .AddChoices(new [] {
                    "Next",
                    "Exit",
                }));

            if (play == "Exit") {
                cancel = true;
            }
        }

        static void failed() {
            AnsiConsole.Clear();
            level = level + 1;
            lose = lose + 1;

            AnsiConsole.Write(
                new FigletText("Anda Kalah")
                .LeftAligned()
                .Color(Color.Red)
            );

            string play;

            // choice
            AnsiConsole.Markup(
                $" [lime]Angka[/] dadu anda [darkorange]lebih kecil[/] dari [red]pc[/]\n" +
                $" - skor [green]anda {win}[/] \n" +
                $" - skor [red]pc {lose}[/] \n\n"
            );

            play = AnsiConsole.Prompt(
                new SelectionPrompt < string > ()
                .AddChoices(new [] {
                    "next",
                    "Exit",
                }));
            
            if (play == "Exit") {
                cancel = true;
            }
        }

        static void draw() {
            AnsiConsole.Clear();

            level = level + 1;
            AnsiConsole.Write(
                new FigletText("Draw")
                .LeftAligned()
                .Color(Color.Yellow)
            );

            string play;

            // choice
            AnsiConsole.Markup(
                $" [lime]Angka[/] dadu anda [darkorange]sama[/] dengan [red]pc[/]\n" +
                $" - skor [green]anda {win}[/] \n" +
                $" - skor [red]pc {lose}[/] \n\n"
            );

            play = AnsiConsole.Prompt(
                new SelectionPrompt < string > ()
                .AddChoices(new [] {
                    "next",
                    "Exit",
                }));
            
            if (play == "Exit") {
                cancel = true;
            }
        }

        static void over() {
            AnsiConsole.Clear();

            string play;

            AnsiConsole.Write(
                new FigletText("Game Over")
                .LeftAligned()
                .Color(Color.Red)
            );

            AnsiConsole.Markup(
                " Skor permainan :game_die: \n" + 
                $" - [orangered1] skor anda {win} [/] \n" +
                $" - [lime] skor pc {lose} [/]"
            );

            play = "Exit";

            if (play == "Exit") {
                cancel = true;
            }
        }

        // function random
        static int rand(int level) {
            return rnd.Next(0, level);
        }
    }
}