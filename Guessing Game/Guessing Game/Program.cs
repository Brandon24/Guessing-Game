using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int h = 100, l = 0, e = 50, guess;
            
            while (true)
            {
                guess = (h + 1) / 2;
                Console.WriteLine("Is your guess {0}? h, l, e ", guess);
                input = Console.ReadLine();
                
                if (guess >= 0 && guess <= 100)
                {
                    guess = 50;
                    {
                        
                        if (input == "h")
                        {
                            guess = 75;
                        }


                         else if (input == "l")
                        {
                            guess = 25;
                        }

                         else if (input == "e")
                         {
                             guess = 50;
                         }



                    }

                }

            }

        }
    }
}
            
        
    


      



            
