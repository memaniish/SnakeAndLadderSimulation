using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator program \n");
            Console.WriteLine("Game starts now...");

            Console.WriteLine("Starting position of player 1 and 2 is: 0 0");

            SnakeAndLadder.SwitchPlayers();
            Console.ReadLine();
        }
    }
}
