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
            string[] Words = new string[6]
            {
                "Noun, Place",
                "Phrase, something happeneing present tense",
                "Verb, ed",
                "Verb, action",
                "Name, Person",
                "Verb, action"
                    

            };

            for (int An = 0; An < Words.Length; An++)
            {
                Console.WriteLine(Words[An]);
                Words[An] = Console.ReadLine();
                
            }

            string MadLib = $@"
Mary drove to her {Words[0]}.
when she got there she realized {Words[1]}.
She got {Words[2]}, and then {Words[3]}.
While this was happening, {Words[4]} was {Words[5]}
";

            Console.Write(MadLib);
            Console.ReadLine();

        } 
    }
}
