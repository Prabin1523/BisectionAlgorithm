using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithmHumanPlays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select: 1 for Guessing Game Human Play. ");
            Console.WriteLine("        2 for Guessing Game Computer Play. ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            
            if (userInput == 1)
            {
    
                Random rando = new Random();
                int roll = rando.Next(1, 1000);


                bool run = false;
                while (!run)
                {
                    try
                    {
                        Console.WriteLine("Select a number between 1 and 1000 ");
                        int userGuess = Convert.ToInt32(Console.ReadLine());

                        if (userGuess == roll)
                        {
                            Console.WriteLine("You guessed the number! ");
                            run = true;
                        }
                        else if (userGuess > roll)
                        {
                            Console.WriteLine("Your guess was too high!");
                        }
                        else if (userGuess < roll)
                        {
                            Console.WriteLine("Your guess was too low!");

                        }
                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }

            }
            if(userInput == 2)
            {

                int mySecretNo = 450;

                bool run = false;
                while (!run)
                {
                    try
                    {
                        Console.WriteLine("Computer select a number from 1 and 1000 ");
                        Random rando = new Random();
                        int firstGuess = rando.Next(1, 1000);
                        

                        {
                            Console.WriteLine("First Guess is: " + firstGuess);
                            if (firstGuess == mySecretNo)
                            {
                                Console.WriteLine("You guessed the number!");
                                run = true;
                            }

                            else if (firstGuess > mySecretNo)
                            {
                                Console.WriteLine("Your guess was too high!");
                                Console.WriteLine("Select a number from 1 and " + firstGuess);
                                //Random secondrando = new Random();
                                //int secondGuess = secondrando.Next(1, firstGuess);
                            }

                            else if (firstGuess < mySecretNo)
                            {
                                Console.WriteLine("Your guess was too low! ");
                                Console.WriteLine("Select a numer from 1000 and " + firstGuess);
                                //Random secondrando = new Random();
                                //int secondGuess = secondrando.Next(firstGuess, 1000);
                            }

                        }

                        

                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }


                
            }



        }
    }
}







