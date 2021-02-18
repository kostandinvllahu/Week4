using System;

namespace Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig dice game");
            bool option = true;
            int choice = 0;
            int score1 = 0;
            int score2 = 0;
            String c = null;

            Console.WriteLine("Users turn roll the dice");
            option = true;
            // if(option == true)
            do
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 6);
                Console.WriteLine(rand_num);
                Console.WriteLine("Do you want to roll again or continue press y for yes and n for no");
                c = Console.ReadLine();
                if(c == "n")
                {
                    Console.WriteLine("PC TURN");
                }
              
            } while (c  == "y");
        }
    }
        }

