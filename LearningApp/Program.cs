using System;
namespace LearningApp
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //ListLearning.Program();
            Madlibs.Program();


            bool brycesleeping = true;

            bool bryceisviolent = false;
            //bool result = ;

            // && || !

            // == > < <= >=

            if (brycesleeping)
            {
                Console.WriteLine("he' sleeping");
            }
            if (brycesleeping && bryceisviolent)
            {
                Console.WriteLine("He Awake");
            }





             
            string test = Console.ReadLine();

            bool test2 = test.ToLower() == "yes";
            Console.WriteLine(test2);

            Console.WriteLine(test);
            Console.ReadKey();



        }
    }
}
