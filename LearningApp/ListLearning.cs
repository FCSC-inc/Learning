using System;
using System.Collections.Generic;
namespace LearningApp
{
    static class ListLearning
    {
        public static void Program()
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

            for (int L = 0; L < 5; L++)
            {
                Console.Write(HilterLikesLubba[L]);
                Console.ReadLine();
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
            Console.Clear();

            for (int H = 0; H < Hands.Count; H++)
            {
                Console.Write(Hands[H]);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
