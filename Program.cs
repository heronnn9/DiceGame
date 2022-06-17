using System;

namespace DiceGame
{
    class Program
    {



        static void Main(string[] args)
        {

            int Player1RandomDice;
            int Player2RandomDice;

            int player1Point = 0;
            int player2Point = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                Player1RandomDice = random.Next(1, 7);
                Console.WriteLine("Player 1's dice :  " + Player1RandomDice);

                Player2RandomDice = random.Next(1, 7);
                Console.WriteLine("Player 2's dice : " + Player2RandomDice);

                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                System.Threading.Thread.Sleep(1000);

                if(Player1RandomDice > Player2RandomDice)
                {
                    player1Point++;
                    Console.WriteLine("!!!Player1 wins this round!!!");
                }
                else if (Player1RandomDice < Player2RandomDice){
                    player2Point++;
                    Console.WriteLine("!!!Player 2 wins this round!!");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The score is Player1 : " + player1Point + " Player2 : " + player2Point);
                Console.WriteLine();

            }
            if (player1Point > player2Point)
            {
                Console.WriteLine("Player 1 wins !!");
            }
            else if(player2Point > player1Point)
            {
                Console.WriteLine("Player 2 win !!");
            }
            else
            {
                Console.WriteLine("********DRAW*******");
            }



            Console.ReadKey();
                                       


        }
    }

}

