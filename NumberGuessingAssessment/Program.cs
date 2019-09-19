using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingAssessment
{
    class Program
    {
        public static Random rand = new Random();

        static void Main(string[] args)
        {

            bool Equel = false;
            bool Equel2 = false;
            int loops = 0;
            int Min = 1;
            int Max = 101;

            string choice = "";

            //Program asks user to think of a number between 1 and 10
            Console.WriteLine("Think of a number between 1 and 100");
            //Program waits for confirmation to continue
            Console.WriteLine("Press 'Enter' to continue");

            Console.ReadLine();


            while(!Equel)
            {
                //Generates random number
                int rando = rand.Next(Min, Max);

                Equel2 = false;

                while (!Equel2)
                {
                    //Computer will begin guessing by printing its guess
                    Console.WriteLine(rando);
                    Console.WriteLine("");

                    //The user must specify to the program whether their number is less than, greater than, or equel to its number
                    Console.WriteLine("Is your number greater than(G), less than(L), or equel(E) to this number?");

                    choice = Console.ReadLine();

                    //If user selects "G" a higher number is generated
                    choice = choice.ToUpper();
                    if (choice == "G")
                    {
                        Equel2 = true;
                        Min = rando;

                        //If user cheats, display text
                        if (Min == Max)
                        {
                            Console.WriteLine("Stop! You violated the law. Pay the court a fine or serve your sentence. Your stolen numbers are now forfeit.");
                        }
                    }

                    //If user selects "L" a lower number is generated
                    else if (choice == "L")
                    {
                        Equel2 = true;
                        Max = rando;

                        //If user cheats, display text
                        if (Min == Max)
                        {
                            Console.WriteLine("Stop! You violated the law. Pay the court a fine or serve your sentence. Your stolen numbers are now forfeit.");
                        }
                    }

                    //If user selects "E" the game ends with the program responding with "Number Solved" and number of attempts it took to guess the number
                    else if (choice == "E")
                    {
                        Equel = true;
                        Equel2 = true;
                        Console.WriteLine("Number Solved");
                        Console.WriteLine("Number of guesses:" + loops);
                    }

                    //If the user selects anything other than G,L,E it will return Invalid
                    else
                    {
                        Console.WriteLine("Invalid");
                    }

                    loops++;
                }
               

            }
            

            Console.ReadLine();
        }

    }
}