using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCISES FROM ClASS
            //EXERCISE 5 ======================================

            double branches = 12;
            double apples = 8;
            double basket = 5;

            Console.WriteLine("Enter the number of trees: ");
            string tree = Console.ReadLine();
            double convertedTree = Convert.ToDouble(tree);

            double result = ((branches * apples / basket) * convertedTree);
            Console.WriteLine("You need " + Math.Ceiling(result) + " baskets to collect all the apples.");


            //EXERCISE 6 ======================================

            //Console.WriteLine("Please enter the first number:");
            //string firstNumber = Console.ReadLine();
            //Console.WriteLine("Please enter the second number:");
            //string secondNumber = Console.ReadLine();

            //int conFirstNumber = Convert.ToInt32(firstNumber);
            //int conSecondNumber = Convert.ToInt32(secondNumber);

            //if (conFirstNumber > conSecondNumber)
            //{
            //    Console.WriteLine("Between the numbers that you have chosen " + conFirstNumber + " is the larger number.");
            //    if (conFirstNumber % 2 == 1)
            //    {
            //        Console.WriteLine("It is an odd number.");
            //    } else
            //    {
            //        Console.WriteLine("It is an even number.");

            //    }
            //} else
            //{
            //    Console.WriteLine("Between the numbers that you have chosen " + conSecondNumber + " is the larger number.");
            //    if (conSecondNumber % 2 == 1)
            //    {
            //        Console.WriteLine("It is an odd number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("It is an even number.");

            //    }
            //};


            //EXERCISE 7 =======================================

            //Console.WriteLine("Please enter a number from 1 to 3:");
            //string input = Console.ReadLine();

            //int conInput = Convert.ToInt32(input);

            //switch (conInput)
            //{
            //    case 1:
            //        Console.WriteLine("You got a new car!");
            //        break;

            //    case 2:
            //        Console.WriteLine("You got a new plane!");
            //        break;

            //    case 3:
            //        Console.WriteLine("You got a new bike!");
            //        break;

            //    default:
            //        Console.WriteLine("You have entered a wrong number. Please try again!");
            //        break;
            //}


            //TASKS FOR HOMEWORK 
            //TASK 1 ======================================

            //Console.WriteLine("Welcome to the \"Real Calculator\".\nPlease write down the first number.");
            //string firstNum = Console.ReadLine();
            //int conFirstNum = Convert.ToInt32(firstNum);

            //Console.WriteLine("Please write down the second number.");
            //string secondNum = Console.ReadLine();
            //int conSecondNum = Convert.ToInt32(secondNum);

            //Console.WriteLine("Now choose the operation you want to be done. Write +, - , * or / .");
            //string sign = Console.ReadLine();


            //switch (sign)
            //{
            //    case "+":
            //        Console.WriteLine("The result is: " + (conFirstNum + conSecondNum));
            //        break;

            //    case "-":
            //        Console.WriteLine("The result is: " + (conFirstNum - conSecondNum));
            //        break;

            //    case "*":
            //        Console.WriteLine("The result is: " + (conFirstNum * conSecondNum));
            //        break;

            //    case "/":
            //        Console.WriteLine("The result is: " + (conFirstNum / conSecondNum));
            //        break;

            //    default:
            //        Console.WriteLine("You have entered a wrong operation. Please try again!");
            //        break;
            //}


            ////TASK 2 =============================
            
            //Console.WriteLine("Welcome to the \"Average Number Calculator\".\nPlease write down the first number.");
            //double conFirst = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Now write down the second number.");
            //double conSecond = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Write down the third number.");
            //double conThird = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("And now write doen the last one.");
            //double conFourth = Convert.ToDouble(Console.ReadLine());

            //double result = (conFirst + conSecond + conThird + conFourth) / 4;
            //Console.WriteLine($"The average of {conFirst}, {conSecond}, {conThird} and {conFourth} is {result}.");


            //TASK 3 ==============================

            //Console.WriteLine("Welcome to the \"Swap numbers application\".\nPlease write down the first number.");
            //int firstN = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Now write down the second number.");
            //int secondN = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine($"Before swapping the value of the first number is {firstN} and of the second one is {secondN}.");
            //Console.WriteLine("Press enter to swap their values.");
            //Console.ReadLine();


            //firstN = firstN + secondN;
            //secondN = firstN - secondN;
            //firstN = firstN - secondN;

            //Console.WriteLine($"After swapping the new value of the first number is {firstN} and of the second one is {secondN}.");





            Console.ReadLine();
        }
    }
}
