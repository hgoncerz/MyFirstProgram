using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while (player != "ROCK" && player != "PAPER" && player !="SCISSORS")
                {
                    Console.Write("Enter Rock, Paper, or Scissors: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch(random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer " + computer);

                switch (player)
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }else if(computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("you win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Draw!");
                        }
                        else
                        {
                            Console.WriteLine("you lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("you lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;  
                }
                Console.WriteLine("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if(answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                Console.WriteLine("Thanks for playing");
            }

            Console.ReadKey();


        }
    }
}