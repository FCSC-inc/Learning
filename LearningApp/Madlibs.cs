using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    static class Madlibs
    {
        public static void Program()
        {
            string[] Words = new string[5]
            {
                "Noun, Place",
                "Verb, ending in ed",
                "Verb, ending in ed",
                "Name, Person",
                "Verb, ending in ed"
            };

            for (int An = 0; An < Words.Length; An++)
            {
                Console.WriteLine(Words[An]);
                Words[An] = Console.ReadLine();
                
            }

            string MadLib = $@"
Mary drove to {Words[0]}.
when she got there she realized something.
She got {Words[1]}, and then {Words[2]}.
While this was happening, {Words[3]} was {Words[4]}
";

            Console.Write(MadLib);
            Console.ReadLine();

        } 
    }
}
