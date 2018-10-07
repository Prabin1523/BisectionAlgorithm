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

                int mySecretNo = 3;

                //bool run = false;
                //while (!run)
                {
                    try
                    {
                        Console.WriteLine("Computer select a number from 1 and 10 ");
                        Random rando = new Random();
                        int firstGuess = rando.Next(1, 1000);
                        Console.Clear();

                        {
                            Console.WriteLine("First Guess is: " + firstGuess);
                            if (firstGuess == mySecretNo)
                            {
                                Console.WriteLine("You guessed the number!");
                                //run = true;
                            }

                            else if (firstGuess > mySecretNo)
                            {
                                Console.WriteLine("Your guess was too high!");
                                Console.WriteLine("Select a number between 1 and " + firstGuess);


                                Random secondrando = new Random();
                                int secondGuess = secondrando.Next(1, firstGuess);
                            }

                            else if (firstGuess < mySecretNo)
                            {
                                Console.WriteLine("Your guess was too low! ");
                                Console.WriteLine("Select a number between 5 and " + firstGuess);
                                Random secondrando = new Random();
                                int secondGuess = secondrando.Next(1000, firstGuess);
                            }
                        }

                        

                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }


                //            Scanner in = new Scanner(System.in);
                //            Random rand = new Random();
                //            int randNum = 0;
                //            int upperLimit = 100;
                //            int lowerLimit = 1;
                //            String myAnswer = "";

                //            do
                //            {
                //                randNum = rand.nextInt(upperLimit - lowerLimit + 1) + lowerLimit;
                //                System.out.println("I think it's " + randNum);
                //                myAnswer = in.nextLine();

                //                if (myAnswer.equals("tl"))
                //                {  //too low
                //                    lowerLimit = randNum + 1;
                //                }
                //                else if (myAnswer.equals("th"))
                //                { // too high
                //                    upperLimit = randNum - 1;
                //                }
                //            } while (!myAnswer.equals("y"));

                //in.close();
                //            System.out.println("YAAAY! :D");


            }



        }
    }
}







