﻿using System;

namespace Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig dice game");
            //  bool option = true;
            // int choice = 0;
            //=======================KOMENTE PER RREGULLIM ERRORI==================
            //KUR DEL NJE PIKET TOTALE FSHIHEN TE GJITHA!
            //RREGULLOJE QE TE RRUAJ PIKET TOTALE TE FITUARA DHE TE FSHIHEN ATO QE NUK KA BERE SAVE
            //======================================================================
           // int saveScore = 0; 
            int score1 = 0;
            int score2 = 0;
            int temp = 0;
            int temp1 = 0;
            int a = 0;
            int b = 0;
            String c = null;

           // option = true;
            // if(option == true)
            do
            {
                 
                Console.WriteLine("=============/////USER1 TURN/////========================");
               // b = score2 + temp1;
                Console.WriteLine("USER2 TOTAL POINTS ARE: " + score2);
                Console.WriteLine();
                Console.WriteLine("User1 turn roll the dice");
                Console.WriteLine();
                Random rd = new Random();
                int rand_num = rd.Next(1, 6);
                Console.WriteLine("You rolled the dice and got: " + rand_num);
                Console.WriteLine();
                temp += rand_num;
                if (rand_num == 1) //KJO PUNON
                {
                    temp = 0;
                    Console.WriteLine("You lost your earned scores and now you have: " +  temp);
                    c = "n";
                    Console.WriteLine();
                }
                else
                {
                    b = score1 + temp;
                    Console.WriteLine("Total points earned are: " + score1 + " and if you save your total score is " + b);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to roll again or hold press y for yes and n for no");
                    Console.WriteLine();
                    c = Console.ReadLine();

                    if (score1 >= 30)
                    {
                        Console.WriteLine("USER1 IS WINNER");
                        Console.WriteLine();
                        score1 = 0;
                        temp = 0;
                        score2 = 0;
                        temp1 = 0;
                    }
                }
                if(c == "n")
                {
                    
                    do
                    {
                        Console.WriteLine("===========////USER2 TURN/////=====================");
                        score1 += temp;
                        temp = 0;
                        //a = score1 + temp;
                        Console.WriteLine("USER1 TOTAL POINTS ARE: " + score1);
                        Console.WriteLine();
                        Console.WriteLine("User2 turn roll the dice");
                        Console.WriteLine();
                        //Random rd = new Random();
                        int rand_num1 = rd.Next(1, 6);
                        //==========KE SHTUAR KETE RRJESHT KODI!==================
                       /* b = score2 + temp1;
                        Console.WriteLine("Score is: " + b);
                        */
                        //=========================================================
                        Console.WriteLine("You rolled the dice and got: " + rand_num1);
                        Console.WriteLine();
                        temp1 += rand_num1;
                        if (rand_num1 == 1)
                        {
                            temp1 = 0;
                            Console.WriteLine("You lost your earned scores and now you have: " + score2);
                            c = "y";
                            Console.WriteLine();
                        }
                        else
                        {
                            a = score2 + temp1;
                            Console.WriteLine("Total points earned are: " + score2 + " and if you save your total score is " + a);
                            Console.WriteLine();
                            Console.WriteLine("Do you want to roll again or hold press y for yes and n for no");
                            Console.WriteLine();
                            c = Console.ReadLine();
                            if (score2 >= 30)
                            {
                                Console.WriteLine("USER2 IS WINNER");
                                Console.WriteLine();
                                score1 = 0;
                                temp = 0;
                                score2 = 0;
                                temp1 = 0;
                            }
                        }
                        if (c == "y")
                        {
                            score2 += temp1;
                            //b = score2 + temp1;
                            //Console.WriteLine("Total score for User1 is:  " + score2);
                            Console.WriteLine();
                        }
                    } while (c == "n");
                }
              
            } while (c  == "y");   
        }
    }
  }

