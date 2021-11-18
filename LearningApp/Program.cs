using System; 
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LearningApp
{



    class Program
    {
      
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;

            List<int> Fuckoff = new List<int>();
            Fuckoff.Add(1);
            Fuckoff.Add(2);
            Fuckoff.Add(3);
            Fuckoff.Add(4);

            var cities = new List<string>();
            cities.Add("New Bloxburg");
            cities.Add("Lubba's Cave");
            cities.Add("Argentina (The Country)");
            cities.Add("FUck Off Ville");

            var bigCities = new List<string>()
            {
                "New Bloxburg",
                "Lubba's Cave",
                "Argentina (The Country)",
                "Fuck off Ville",
            };

            string[] Hitlerdidnothingwrong = new string[3] { "lubba's House", "Lubba's Bathroom", "Lubba's THoughts" };

            var popularCities = new List<string>();

            popularCities.AddRange(cities);
            var favouriteCities = new List<string>();

            Console.WriteLine(Hitlerdidnothingwrong[0]);
            Console.WriteLine(Hitlerdidnothingwrong[1]);
            Console.WriteLine(Hitlerdidnothingwrong[2]);
            Console.ReadLine();




            





        }


    }
}
