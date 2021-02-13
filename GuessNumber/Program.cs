using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {


        static void Main(string[] args)
        {

            textColor(ConsoleColor.Yellow, "This game has been  created by Vladd");


            textColor(ConsoleColor.White, "Please enter your name : ");




            string playerName = Console.ReadLine();


            textColor(ConsoleColor.Blue, "Hello " + playerName.ToLower() + " , let's play a game...");
            Console.WriteLine();


            Console.WriteLine("Choose a max number to guess (From 1 to your choice) : ");
            string choosedNumber = Console.ReadLine();
            int number = 0;
            int.TryParse(choosedNumber, out number);

            try
            {
                number = Int32.Parse(choosedNumber);

                if (number > Int32.MaxValue)
                {
                    Console.WriteLine("OMG WHAT NUMBER ARE YOU WRITING?? , if you really want a so high number , atleast choose the max one , that is " + Int32.MaxValue);


                }

            }
            catch (Exception e)
            {
                textColor(ConsoleColor.Red, "OMG WHAT NUMBER ARE YOU WRITING?? , if you really want a so high number , atleast choose the max one , that is " + Int32.MaxValue);

            }



            textColor(ConsoleColor.Blue, "Please choose a number between " + 1 + " and " + number);





            while (true)
            {


                Random random = new Random();

                int correctNumber = random.Next(0, number);


                int guess = 0;
                int tryies = 0;

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess) || input == "Number".ToLower())
                    {
                        if (input == "Number".ToLower())
                        {
                            Console.WriteLine("The correct number is " + correctNumber);
                            continue;
                        }
                       
                        else
                        {    
                            textColor(ConsoleColor.Red, "Please enter a correct number");
                            Console.ResetColor();
                            continue;
                        }
                    }

                    guess = Int32.Parse(input);
                    if (guess < correctNumber)
                    {

                        textColor(ConsoleColor.Red, " Too low !! , keep guessing");
                        tryies++;

                    }
                    else if (guess > number)
                    {
                        textColor(ConsoleColor.Red, "Hey , what are you writing? The max number is higher than what you choose , your max number is " + number + "!!");
                    }
                    else if (guess > correctNumber)
                    {
                        textColor(ConsoleColor.Yellow, "Too high , try  more!!");
                        tryies++;
                    }



                    if (guess == correctNumber)
                    {
                        textColor(ConsoleColor.Green, "Well done , you guessed the number!!");
                        if (tryies < 10)
                        {
                            textColor(ConsoleColor.Green, "You needed only " + tryies + " tryies to make it , well done");

                            Console.ResetColor();
                        }
                        else if (tryies > 10 && tryies < 20)
                        {
                            textColor(ConsoleColor.Yellow, "You needed  " + tryies + " tryies to make it , but is still good!!");
                        }
                        else if (tryies > 20)
                        {
                            textColor(ConsoleColor.Red, "You needed  " + tryies + " tryies to make it , you are a pretty bad guesser LOL !!!!");
                        }

                    }

                }
                textColor(ConsoleColor.Green, "Thank you for playing my game!");
                Console.WriteLine();
                Console.WriteLine("Press any key to finish...");
                Console.ReadKey(true);
                return;





            }
        }


        static void textColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void theNumber(int num1)
        {
            Console.WriteLine("Choose a max number to guess : ");
            string choosedNumber = Console.ReadLine();
            int.Parse(choosedNumber);
            Console.WriteLine("Please choose a number between " + num1 + " and " + choosedNumber);
        }
    }
}


