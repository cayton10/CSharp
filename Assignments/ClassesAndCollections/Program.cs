using System;

namespace ClassesAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a couple of players to test

            Player player1 = new Player("John");
            Player player2 = new Player("Jerry");

            player1.PlayGame(player1.PlayerName, player2.PlayerName);
        }
    }
}
