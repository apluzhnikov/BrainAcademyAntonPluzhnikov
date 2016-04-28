using FarmerApp.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gamePlay = new GamePlay();

            MoveStrategyLeft moveStrategyLeft = new MoveStrategyLeft();
            MoveStrategyRight moveStrategyRight = new MoveStrategyRight();

            farmer:
            Dictionary<int, string> possibleMovments = new Dictionary<int, string>()
            {
                {1, "There: farmer and wolf" },
                {2, "There: farmer and cabbage" },
                {3, "There: farmer and goat" },
                {4, "There: farmer" },
                {5, "Back: farmer and wolf" },
                {6, "Back: farmer and cabbage" },
                {7, "Back: farmer and cabbage" },
                {8, "Back: farmer" }
            };

            Console.WriteLine("Instructions");
            foreach (KeyValuePair<int, string> move in possibleMovments)
            {
                Console.WriteLine("Key: {0}, Move: {1}", move.Key, move.Value);
            }

            do
            {
                Console.WriteLine("Your next step?");
                var step = int.Parse(Console.ReadLine());

                switch (step)
                {
                    case 1:
                        gamePlay.SetStrategy(moveStrategyRight);
                        gamePlay.DoMove(Objects.FarmersStuff.Wolf);
                        break;
                    case 2:
                        gamePlay.SetStrategy(moveStrategyRight);
                        gamePlay.DoMove(Objects.FarmersStuff.Cabbage);
                        break;
                    case 3:
                        gamePlay.SetStrategy(moveStrategyRight);
                        gamePlay.DoMove(Objects.FarmersStuff.Sheep);
                        break;
                    case 4:
                        gamePlay.SetStrategy(moveStrategyRight);
                        gamePlay.DoMove(Objects.FarmersStuff.Farmer);
                        break;
                    case 5:
                        gamePlay.SetStrategy(moveStrategyLeft);
                        gamePlay.DoMove(Objects.FarmersStuff.Wolf);
                        break;
                    case 6:
                        gamePlay.SetStrategy(moveStrategyLeft);
                        gamePlay.DoMove(Objects.FarmersStuff.Cabbage);
                        break;
                    case 7:
                        gamePlay.SetStrategy(moveStrategyLeft);
                        gamePlay.DoMove(Objects.FarmersStuff.Sheep);
                        break;
                    case 8:
                        gamePlay.SetStrategy(moveStrategyLeft);
                        gamePlay.DoMove(Objects.FarmersStuff.Farmer);
                        break;
                }
                

            } while (!gamePlay.Finished());


            Console.WriteLine("Do you want to play more? y/n");
            if (Console.ReadLine() == "y")
                goto farmer;
        }
    }
}
