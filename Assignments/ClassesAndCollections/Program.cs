using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassesAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            //Create a couple of players to test
            Player player1 = new Player("John");
            Player player2 = new Player("Jerry");

            player1.PlayGame(player1, player2);


            string name1 = "Bob";
            string name2 = "Thomas";
            string name3 = "Antonio";
            string name4 = "Brad";

            //Create array to store playerNames
            string[] playerNames = { name1, name2, name3, name4 };
                       
            
            //Create instance of program so I can call function Players()
            Program p = new Program();


            //Instantiate list of players using prescribed function
            List<Player> PlayerList = (p.Players(playerNames));



            //Play games
            for(int i = 0; i < PlayerList.Count(); ++i)
            {
                var firstPlayer = PlayerList[i];
                

                for(int k = 0; k < 5; k++ )
                {
                    int rando;

                    //Do while to generate random players within the list
                    do
                    {

                        Random randomIndex = new Random();
                        rando = randomIndex.Next(0, playerNames.Count());

                    } while (rando == i);

                    //Assign random index to randomPlayer
                    var randomPlayer = PlayerList[rando];
                    firstPlayer.PlayGame(firstPlayer, randomPlayer);

                }
            }


            //Use LINQ to display leaderboard
            var sortedByWins = from player in PlayerList
                               orderby player.Wins descending
                               select player;
            Console.WriteLine("PaperClip, HandGrenade, ThermonuclearDevice Leaderboard:\n");

            foreach (var playerWins in sortedByWins)
            {
                Console.WriteLine(playerWins.PlayerName + "'s Wins: " +
                    playerWins.Wins + ", Losses: " + playerWins.Losses);
            }

        }

        //Create function to accept any number of player names
        List<Player> Players(params string[] playerNames)
        {
            //Declare out list of players
            List<Player>allPlayers = new List<Player>();

            foreach (var player in playerNames)
            {
                allPlayers.Add(new Player(player));
            }

            return allPlayers;
        }
    }
}
