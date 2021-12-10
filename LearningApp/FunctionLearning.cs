using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LearningApp
{
    class FunctionLearning
    {
        // load a file
        // file has <param> in it
        // we replace the <param> with the word the user types
        // we also have to say param to the user to tell them what to type

        //ex:
        // mary <verb(ed)> is a parameter
        // we say to the console verb(ed
        // re replace <verb(ed)> in the original string




        string ParameterBoBameter(string str)
        {
            if (str == null)
                return null;

            // madlib, the madlib has parameters
            // the paramteters start with < end with > <param1> <param2> <param3>
            // what if we passed 4 as the index when there are three parameters? return null
            char character= '>';
            int index = GetIndexOfChar(str, '<');
            Console.WriteLine(index);
        }
        int GetIndexOfChar(string str, char character)
        {
            // loop through the string, check if the current caracter is equal to char
            // return the current index
            // otherwise return -1;

        }
    }
}
