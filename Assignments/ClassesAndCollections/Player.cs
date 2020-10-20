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

        public void PlayGame(string name1, string name2)
        {
            //Check if playing against self
            if (name1 != name2)
            {
                //Instantiate player choices of type random
                Random playerOneChoice = new Random();
                //Provide second random choice constructor w/ different seed val
                Thread.Sleep(20);
                Random playerTwoChoice = new Random();

                int choice1 = playerOneChoice.Next(1, 4);
                int choice2 = playerTwoChoice.Next(1, 4);

                Console.WriteLine(name1);

                var weapon1 = (Actions)choice1;
                Console.WriteLine($"{name1}'s weapon: {weapon1}");

                var weapon2 = (Actions)choice2;
                Console.WriteLine($"{name2}'s weapon: {weapon2}");

            }
            else
                return;
        }
    }
}
