using System;
using System.Collections.Generic;

namespace LearningApp
{



    class Program
    {
      
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            string[] HilterLikesLubba = new string[5] 
            { 
                "Hitler's Favorite Places",
                "---------------- ",
                "Lubba's House",
                "Lubba's Bathroom",
                "Lubba's Thoughts"
            };

            for (int i = 0; i < 5; i++)
            {

            }
           
            

            List<string> Hands = new List<string>()
            {
                @"
                ░░░░░░░░░░░░░░░░░░░░░
                ░░░▄█▀█▄█▀█▄▄▄░░░░░░░
                ░░█▒░░▀█▄▄░░░▀▀█░░░░░
                ░█▒░░░░░▒░░░░▒▄░▀▀█▄░
                ░█▒░░░░█▒░░▄▀░░░▒░░█░
                ░█▒░░░█▒░░█▀▒░░█▀░░▀█
                ░█▒░░░█▒░░█▒░░█▓░░░▓█
                ▄▀█▓▓░█▒░▓█▓░░█▓░░▓▄█
                █▒▒████▄▓▓█▓░░█▓░░▄█░
                █▒▒░░░░░▀█▄▀░▄▀▓▄█▀░░
                █▒▓▓▓█▀▀▄▀█▄▄▀▄▄▀░░░░
                ░▀▄▄▄█▄▄▀░░░░░░░░░░░░
                ",@"
                __________$$$$$$
                _________$$____$$
                _________$$$__$$$
                _________$$_$$_$$
                _________$$____$$
                _________$$____$$
                _________$$____$$
                _________$$____$$$$$$$
                ___$$$$$$$$____$$____$$
                _$$$$$___$$____$$____$$$$$$
                $$$_$$___$$____$$____$$___$$
                $$__$$___$$____$$____$$___$$
                $$__$$___$$____$$____$$___$$
                $$__$$___$$____$$___$$$___$$
                $$__$$___$$____$$____$____$$
                $$____$$$__$$$$__$$$$___$_$$
                $$________________________$$
                _$$_______________________$$
                _$$$_____________________$$
                __$$$$_________________$$$
                ____$$_________________$
                ____$$$_______________$$
                " 
            };
            Console.WriteLine(Hands[0]);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine(Hands[1]);

            Console.ReadLine();











        }


    }
}
