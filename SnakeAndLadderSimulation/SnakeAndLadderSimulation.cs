using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Simulator
{
    internal class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        public static int DiceRoll, players = 1;

        public static int[] player = new int[3] { 0, 0, 0 };
        public static int[] playerDiceCount = new int[3] { 0, 0, 0 };

        public static Random random = new Random();

        public static void SwitchPlayers()
        {

            while (player[1] < WINNING_POSITION && player[2] < WINNING_POSITION)
            {
                if (players == 1)
                {
                    PlaySnakeAndLadder(1);
                    players = 2;
                    continue;

                }
                if (players == 2)
                {
                    PlaySnakeAndLadder(2);
                    players = 1;
                    continue;

                }
            }
        }

        public static void PlaySnakeAndLadder(int playerNum)
        {
            DiceRoll = random.Next(1, 7);
            Console.WriteLine("\nPlayer {0} gets Dice value: {1}", playerNum, DiceRoll);
            playerDiceCount[playerNum]++;

            switch (random.Next(0, 3))
            {
                case NO_PLAY:
                    Console.WriteLine("(No Play) Player Position: " + player[playerNum]);
                    break;

                case LADDER:
                    player[playerNum] += DiceRoll;

                    if (player[playerNum] > WINNING_POSITION)
                    {
                        player[playerNum] -= DiceRoll;   //Player stays at same position if player position is more than 100
                    }
                    Console.WriteLine("(Ladder) Player Position: " + player[playerNum]);
                    if (player[playerNum] == WINNING_POSITION)
                    {
                        Console.WriteLine("\nPlayer {0} Won the Game With Dice Count Of :{1} ", playerNum, playerDiceCount[playerNum]);
                        break;
                    }
                    PlaySnakeAndLadder(playerNum);       //Player plays again (for ladder option)
                    break;
                case SNAKE:
                    player[playerNum] -= DiceRoll;

                    if (player[playerNum] < 0)
                    {
                        player[playerNum] = 0;           //Player starts from 0 If player position is negative
                    }
                    Console.WriteLine("(Snake) Player Position " + player[playerNum]);
                    break;
            }

        }

    }

}
