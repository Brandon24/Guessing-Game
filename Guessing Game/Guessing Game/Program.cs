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
            
            int guess;
            String Input;
            while (true)
            {
                
               if(guess >= 0 && guess <=100)
               {
                guess = 50;
                {
                Console.WriteLine("Is your guess {0}? h, l, e ", guess);
                Input = Console.ReadLine();
               
                    if (Input == "h")
                {
                    guess = 75;
                    }
                }
                
                    else(Input = "l");
                 
                {
                    guess = 25;
                }




                }

            }

        }

    }
}
            
        
    


      



            
