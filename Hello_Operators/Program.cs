using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Farmer_puzzle();//???temp orary

            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
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
            List<int> rightAnswer = new List<int>() { 3, 8, 2, 7, 1, 8, 3 };
            int currentStep = 0;

            Console.WriteLine("Instructions");
            foreach (KeyValuePair<int, string> move in possibleMovments)
            {
                Console.WriteLine("Key: {0}, Move: {1}", move.Key, move.Value);
            }
                        
            do
            {
                Console.WriteLine("Your next step?");
                var step = int.Parse(Console.ReadLine());
                if (rightAnswer[currentStep] == step)
                {
                    currentStep++;
                    if (currentStep == rightAnswer.Count())
                    {
                        Console.WriteLine("All Alive. You WON:)");
                        break;
                    }
                    else
                        Console.WriteLine("All Alive.....yet :)");
                }
                else
                {
                    Console.WriteLine("Sorry, someone died :(");
                    break;
                }

            } while (currentStep < rightAnswer.Count());

            Console.WriteLine("Do you want to play more? y/n");
            if (Console.ReadLine() == "y")
                goto farmer;


        }
        #endregion

        #region calculator
        static void Calculator()
        {
            calc:
            double firstNumber = 0;
            double secondNumber = 0;

            Console.WriteLine(@"Please enter first value:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Please enter second value:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");

            double operationResult = 0;
            string operation = "";
            switch (Console.ReadLine())
            {
                case "1":
                    operationResult = firstNumber * secondNumber;
                    operation = "*";
                    break;
                case "2":
                    operationResult = firstNumber / secondNumber;
                    operation = "/";
                    break;
                case "3":
                    operationResult = firstNumber + secondNumber;
                    operation = "+";
                    break;
                case "4":
                    operationResult = firstNumber - secondNumber;
                    operation = "-";
                    break;
                case "5":
                    int firstNumberInt = (int)firstNumber;
                    int secondNumberInt = (int)secondNumber;
                    operationResult = firstNumberInt << secondNumberInt;
                    operation = "^";
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operation, secondNumber, operationResult);
            Console.WriteLine("Do you want to play more? y/n");
            if (Console.ReadLine() == "y")
                goto calc;

        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            factorial:

            int factorialNumber = 0;
            Console.WriteLine("Please enter he value for calculation of factorial:");
            factorialNumber = Convert.ToInt32(Console.ReadLine());

            int factorialNumberResult = 1;
            for (int i = factorialNumber; i > 0; i--)
            {
                factorialNumberResult *= i;
            }

            Console.WriteLine("Result for {0}!: {1}", factorialNumber, factorialNumberResult);
            Console.WriteLine("Do you want to play more? y/n");
            if (Console.ReadLine() == "y")
                goto factorial;
        }
        #endregion
    }
}
