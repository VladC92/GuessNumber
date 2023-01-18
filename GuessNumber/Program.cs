using System;

namespace GuessNumber
{
    static class Program
    {
        private static void Main()
        {

            TextColor(ConsoleColor.Yellow, "A game created by Vlad");


            TextColor(ConsoleColor.White, "Please enter your name : ");




            string playerName = Console.ReadLine();


            if (playerName != null)
                TextColor(ConsoleColor.Blue, "Hello " + playerName.ToLower() + " , let's play a game...");
            Console.WriteLine();


            Console.WriteLine("Choose a max number to guess (From 1 to your choice) : ");
            string chooseNumber = Console.ReadLine();
            int.TryParse(chooseNumber, out var number);

            try
            {
                if (chooseNumber != null) number = Int32.Parse(chooseNumber);
            }
            catch (Exception)
            {
                TextColor(ConsoleColor.Red, "OMG WHAT NUMBER ARE YOU WRITING?? , if you really want a so high number , at least choose the max one , that is " + Int32.MaxValue);

            }



            TextColor(ConsoleColor.Blue, "Please choose a number between " + 1 + " and " + number);





            while (true)
            {


                Random random = new Random();

                int correctNumber = random.Next(0, number);


                int guess = 0;
                int tries = 0;

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

                        TextColor(ConsoleColor.Red, "Please enter a correct number");
                        continue;
                    }

                    if (input != null) guess = Int32.Parse(input);
                    if (guess < correctNumber)
                    {

                        TextColor(ConsoleColor.Red, " Too low !! , keep guessing");
                        tries++;

                    }
                    else if (guess > number)
                    {
                        TextColor(ConsoleColor.Red, "Hey , what are you writing? The max number is higher than what you choose , your max number is " + number + "!!");
                    }
                    else if (guess > correctNumber)
                    {
                        TextColor(ConsoleColor.Yellow, "Too high , try  more!!");
                        tries++;
                    }



                    if (guess == correctNumber)
                    {
                        TextColor(ConsoleColor.Green, "Well done , you guessed the number!!");
                        if (tries < 10)
                        {
                            TextColor(ConsoleColor.Green, "You needed only " + tries + " tries to make it , well done");

                            Console.ResetColor();
                        }
                        else if (tries > 10 && tries < 20)
                            TextColor(ConsoleColor.Yellow,
                                "You needed  " + tries + " tries to make it , but is still good!!");
                        else if (tries > 20)
                            TextColor(ConsoleColor.Red,
                                "You needed  " + tries + " tries to make it , you are a pretty bad guesser LOL !!!!");

                    }

                }
                TextColor(ConsoleColor.Green, "Thank you for playing my game!");
                Console.WriteLine();
                Console.WriteLine("Press any key to finish...");
                Console.ReadKey(true);
                return;





            }
        }


        private static void TextColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}


