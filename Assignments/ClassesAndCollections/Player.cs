using System;
using System.Threading;
namespace ClassesAndCollections
{
    public class Player
    {
        private string playerName;
        private int wins;
        private int losses;

        

        //Define properties for private member variables
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }

        //Player constructor
        public Player(string name)
        {
            playerName = name;
        }


        //PlayGame function as described in project outline
        public void PlayGame(Player name1, Player name2)
        {
            //Check if playing against self
            if (name1.playerName != name2.playerName)
            {

                //Instantiate player choices of type random
                Random playerOneChoice = new Random();
                //Provide second random choice constructor w/ different seed val
                Thread.Sleep(20);
                Random playerTwoChoice = new Random();

                int choice1 = playerOneChoice.Next(1, 4);
                int choice2 = playerTwoChoice.Next(1, 4);

                //Check for tying condition
                if(choice1 == choice2)
                {
                    //Reroll choice while choices are same
                    do
                    {
                        choice1 = playerOneChoice.Next(1, 4);
                        choice2 = playerTwoChoice.Next(1, 4);
                    } while (choice1 == choice2);
                }

                //Create logic to find winning condition
                //Update wins and losses for each player as necessary
                if(choice1 == 1 && choice2 == 3)
                {
                    name1.wins++;
                    name2.losses++;
                }
                else if(choice1 == 2 && choice2 == 1)
                {
                    name1.wins++;
                    name2.losses++;
                }
                else if(choice1 == 3 && choice2 == 2)
                {
                    name1.wins++;
                    name2.losses++;
                }
                else
                {
                    name2.wins++;
                    name1.losses++;
                }

            }
            else
                return;
        }
    }
}
