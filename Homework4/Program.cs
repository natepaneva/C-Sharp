using System;

namespace Homework4
{
    class Program
    {

        //Exercise from class methods ================================

        //static double Sum(double num1, double num2)
        //{
        //    return num1 + num2;
        //}

        //static double Substract (double num1, double num2)
        //{
        //    return num1 - num2;
        //}


        // Task 1 ===================================================

        //static void Substring()
        //{
        //    string message = "Hello from SEDC Codecademy v7.0";
        //    Console.WriteLine(message);
        //    Console.WriteLine("Enter a number:");

        //    string input = Console.ReadLine();
        //    int num;
        //    bool parsedInput = int.TryParse(input, out num);

        //    while (!parsedInput)
        //    {
        //        Console.WriteLine("Wrong input. Enter just a number!");

        //        input = Console.ReadLine();
        //        parsedInput = int.TryParse(input, out num);
        //    }

        //    if (parsedInput)
        //    {
        //        while (num <= 0 || num > message.Length)
        //        {
        //            Console.WriteLine("That number is either too small or too big. Try again!");
        //            num = int.Parse(Console.ReadLine());

        //        }

        //        if (num > 0 && num <= message.Length)
        //        {
        //            string newMessage = message.Substring(0, num);
        //            Console.WriteLine(newMessage);
        //            Console.WriteLine($"Your new message has {newMessage.Length} letters.");
        //        }
        //    }

        //}

        // Task 3 ======================================================

        //static void AgeCalculator()
        //{

        //    Console.WriteLine("Input your date of birth writing month, date and year: (ex. 01.17.1994)");
        //    DateTime birthday = DateTime.Parse(Console.ReadLine());
        //    DateTime today = DateTime.Today;

        //    int age = today.Year - birthday.Year;
        //    if (birthday.Date > today.AddYears(-age)) age--;
        //    Console.WriteLine(age);

        //}


        //static void AgeCalculator(DateTime birthday, DateTime today)
        //{

        //    int age = today.Year - birthday.Year;
        //    if (birthday.Date > today.AddYears(-age)) age--;
        //    Console.WriteLine("Your age is {age}.");

        //}





        static void Main(string[] args)
        {
            //Exercise from class solution ================================


            //Console.WriteLine(@"Welcome to the Calculator. Enter ""+"" or ""-"" .");
            //string opperation = Console.ReadLine();

            //while (opperation != "+" && opperation !="-")
            //{
            //    Console.WriteLine(@"You have entered an invalid sign. Enter ""+"" or ""-"" .");
            //    opperation = Console.ReadLine();
            //    break;

            //}

            //while (opperation == "+" || opperation == "-")
            //{
            //    Console.WriteLine("Enter the first number and press enter.");
            //    string input1 = Console.ReadLine();
            //    double num1;
            //    bool parsedNum1 = double.TryParse(input1, out num1);


            //    while (!parsedNum1)
            //    {
            //        Console.WriteLine("Invalid input. Enter just a number!");
            //        input1 = Console.ReadLine();
            //        parsedNum1 = double.TryParse(input1, out num1);

            //    }

            //    Console.WriteLine("Now enter the second number and press enter.");
            //    string input2 = Console.ReadLine();
            //    double num2;
            //    bool parsedNum2 = double.TryParse(input2, out num2);

            //    while (!parsedNum2)
            //    {
            //        Console.WriteLine("Invalid input. Enter just a number!");
            //        input2 = Console.ReadLine();
            //        parsedNum2 = double.TryParse(input2, out num2);

            //    }

            //    if (opperation == "+")
            //    {
            //        Console.WriteLine($"The result is: {Sum(num1, num2)!}");
            //    }
            //    if (opperation == "-")
            //    {
            //        Console.WriteLine($"The result is: {Substract(num1, num2)!}");

            //    }
            //    break;

            //}

            // Task 1 ===================================================

            //Substring();


            //Task 2 ====================================================


            //DateTime today = DateTime.Now;
            //DateTime currentDate = today.Date;


            //Console.WriteLine($"Todays date is: {currentDate}.");
            //Console.WriteLine($"The date three days from now will be {currentDate.AddDays(3)}.");
            //Console.WriteLine($"The date one month and three days from now will be {currentDate.AddMonths(1).AddDays(3)}.");
            //Console.WriteLine($"The date one year and two months ago was {currentDate.AddYears(-1).AddMonths(-2)}.");
            //Console.WriteLine($"The current month is { today.ToString("MMMM")}.");
            //Console.WriteLine($"The current year is {today.Year}.");


            //Task 3 ====================================================

            //Console.WriteLine("Input your date of birth writing month, date and year: (ex. 01.17.1994)");

            //DateTime today = DateTime.Today;

            //string input = Console.ReadLine();
            //DateTime birthday;
            //bool parsedInput = DateTime.TryParse(input, out birthday);

            //while (!parsedInput)
            //{
            //    Console.WriteLine("Thar is wrong input. Write month, date and year: (ex. 01.17.1994)");
            //}
            //if (parsedInput)
            //{
            //    AgeCalculator(birthday, today);
            //}
            


            Console.ReadLine();
        }

    }
}
