using System;

namespace Break_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. FLIP THE BOOLEAN ==============================================


            Console.WriteLine(@"Please write ""true"" or ""false"".");
            string input = Console.ReadLine();
            bool trueOrFalse;
            bool parsed = bool.TryParse(input, out trueOrFalse);


            if (input == "true" || input == "false")
            {

                if (input == "true")
                {
                    parsed = !true;
                    Console.WriteLine(parsed);
                }
                else if (input == "false")
                {
                    parsed = !false;
                    Console.WriteLine(parsed);
                }
            }
            else
            {
                Console.WriteLine(@"Error, incorrect value. Please restart the program and write ""true"" or ""false"".");
            }



            //2. MULTIPLE OF 100 ===============================================



            //Console.WriteLine("Please enter a number:");

            //string input = Console.ReadLine();
            //double num;
            //bool inputParsed = double.TryParse(input, out num);

            //if (inputParsed)
            //{
            //    if (num % 100 == 0)
            //    {
            //        Console.WriteLine("You have entered a cool number!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number you've entered is not cool at all!");
            //    }
            //}

            //else if (inputParsed == false)
            //{
            //    Console.WriteLine("Can't you read? Restart the program and enter a number, not anything else!");
            //}



            //3. RETURN NAME OF MONTH ==========================================



            //Console.WriteLine("Enter a number from 1-12:");

            //string input = Console.ReadLine();
            //int month;
            //bool inputParsed = Int32.TryParse(input, out month);

            //if (inputParsed)
            //{
            //    switch (month)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        case 4:
            //            Console.WriteLine("April");
            //            break;
            //        case 5:
            //            Console.WriteLine("May");
            //            break;
            //        case 6:
            //            Console.WriteLine("June");
            //            break;
            //        case 7:
            //            Console.WriteLine("July");
            //            break;
            //        case 8:
            //            Console.WriteLine("August");
            //            break;
            //        case 9:
            //            Console.WriteLine("September");
            //            break;
            //        case 10:
            //            Console.WriteLine("October");
            //            break;
            //        case 11:
            //            Console.WriteLine("November");
            //            break;
            //        case 12:
            //            Console.WriteLine("December");
            //            break;
            //        default:
            //            Console.WriteLine("Error, incorrect value. Restart the program and enter a number from 1-12!");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error, incorrect input. Restart the program and enter just a number!");
            //}



            //4. PPROFITABLE GAMBLE ============================================



            //Console.WriteLine("Welcome player! Enter the probability of winning (number between 0 and 1, ex. 0.3) ");
            //string prob = Console.ReadLine();
            //double probability;
            //bool probParsed = double.TryParse(prob, out probability);

            //if (probParsed && probability > 0 && probability < 1)
            //{
            //    Console.WriteLine("Nice job. Now enter the value of the prize. Any integer greater than 0 is acceptable.");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input. Restart the program and read the instructions carefully!");
            //}

            //string prize = Console.ReadLine();
            //int prizeInt;
            //bool prizeParsed = Int32.TryParse(prize, out prizeInt);

            //if (prizeParsed && prizeInt > 0)
            //{
            //    Console.WriteLine("Well done. As a last input enter any integer greater than 0 as the cost of playing.");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input. Restart the program and read the instructions carefully!");

            //}

            //string cost = Console.ReadLine();
            //int costInt;
            //bool costParsed = Int32.TryParse(cost, out costInt);

            //double netOutcome = probability * prizeInt - costInt;

            //if (costParsed && costInt > 0)
            //{
            //    Console.WriteLine("Great. Now lets see your result.");
            //    if (netOutcome > 0)
            //    {
            //        Console.WriteLine("Congratulations. You have won!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you have lost.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect input. Restart the program and read the instructions carefully!");

            //}



            // 5. THE FARM PROBLEM =============================================



            //Console.WriteLine("To calculate the number of legs enten the number of chickens, cows and pigs consequently.");

            //string chickensInput = Console.ReadLine();
            //int chickens;
            //bool chickensParsed = Int32.TryParse(chickensInput, out chickens);


            //string cowsInput = Console.ReadLine();
            //int cows;
            //bool cowsParsed = Int32.TryParse(cowsInput, out cows);


            //string pigsInput = Console.ReadLine();
            //int pigs;
            //bool pigsParsed = Int32.TryParse(pigsInput, out pigs);

            //int legs = chickens * 2 + (cows + pigs) * 4;

            //if (chickensParsed && cowsParsed && pigsParsed && chickens >= 0 && cows >= 0 && pigs >= 0)
            //{
            //    Console.WriteLine($"The total number of legs of all the animals is {legs}.");
            //}
            //else
            //{
            //    Console.WriteLine("It seems that some of the inputs are invalid. Restart the program and try again.");
            //}



            // 6. WORD COUNT ===================================================



            //Console.WriteLine("Enter a sentence to calculate the words in it.");

            //string sentence = Console.ReadLine();
            //int result = sentence.Split(' ').Length;

            //if (result > 1)
            //{
            //    Console.WriteLine($"This sentence have {result} words.");
            //}
            //if (result == 1)
            //{
            //    Console.WriteLine($"This sentence has just {result} word.");
            //}
            //else 
            //{
            //    Console.WriteLine("That doesn't look like a sentence. Restart the program and try again.");
            //}



            //7. LIQUOR STORE ==================================================



            //Console.WriteLine("Welcome to our liquor store. Please tell us your name:");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("And your last name is:");
            //string lastName = Console.ReadLine();

            //if (firstName.Length < 2 && lastName.Length < 2)
            //{
            //    Console.WriteLine("Your name is too short!");
            //}
            //else if (firstName.Length > 15 && lastName.Length < 20)
            //{
            //    Console.WriteLine("Your name is too long!");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello {firstName} {lastName}. What is your age?");
            //}


            //string age = Console.ReadLine();
            //int ageInt;
            //bool ageParsed = Int32.TryParse(age, out ageInt);

            //string drinkName = "Alexadria Cuvee";


            //if (ageParsed)
            //{
            //    if (ageInt >= 18)
            //    {
            //        Console.WriteLine($"Dear {firstName} {lastName} here you are a bottle of {drinkName}, have a nice day! ");

            //    }
            //    else if (ageInt < 18 && ageInt > 0)
            //    {
            //        Console.WriteLine($"Dear {firstName} {lastName}, we are sorry but you are not allowed to buy alchocol.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid input!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid input!");
            //}



            //8. COFFEE MACHINE ================================================



            //Console.WriteLine("Welcome dear customer, please select a drink: \n1.Espresso...........2$ \n2.Macchiato........3,5$ \n3.Latte..............4$ \n4.Cappuccino.........6$ \n5.Tea..............1.5$");
            //string inputCoffee = Console.ReadLine();
            //double number;
            //bool coffeeParsed = double.TryParse(inputCoffee, out number);

            //if (coffeeParsed && number >= 1 && number <= 5)
            //{

            //    Console.WriteLine("Select your strength of sweetness from 1-5:");

            //}
            //else
            //{
            //    Console.WriteLine("Wrong input. Restart the program and try again!");
            //}

            //double price;
            //string drink;

            //switch (number)
            //{
            //    case 1:
            //        drink = "Espresso";
            //        price = 2;
            //        break;

            //    case 2:
            //        drink = "Macchiato";
            //        price = 3.5;
            //        break;

            //    case 3:
            //        drink = "Cappuccino";
            //        price = 4;
            //        break;

            //    case 4:
            //        drink = "Latte";
            //        price = 6;
            //        break;

            //    case 5:
            //        drink = "Tea";
            //        price = 1.5;
            //        break;

            //    default:
            //        drink = "";
            //        price = 0;
            //        break;
            //}


            //string inputSugar = Console.ReadLine();
            //double numSugar;
            //bool sugarParsed = double.TryParse(inputSugar, out numSugar);

            //if (sugarParsed && numSugar >=1 && numSugar <=5)
            //{
            //    Console.WriteLine("Input your money:");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input. Restart the program and try again");

            //}

            //string sweetness;

            //switch(numSugar)
            //{
            //    case 1:
            //        sweetness = "bitter";
            //        break;

            //    case 2:
            //        sweetness = "slightly sweet";
            //        break;

            //    case 3:
            //        sweetness = "medium sweet";
            //        break;

            //    case 4:
            //        sweetness = "really sweet";
            //        break;

            //    case 5:
            //        sweetness = "sorbet";
            //        break;

            //    default:
            //        sweetness = "medium sweet";
            //        break;

            //}


            //string inputMoney = Console.ReadLine();
            //double money;
            //bool moneyParsed = double.TryParse(inputMoney, out money);

            //double change = money - price;

            //if (moneyParsed)
            //{
            //    if (change > 0)
            //    {
            //        Console.WriteLine($"Here is your {sweetness} {drink}, your change is {change}$. Enjoy!");
            //    }
            //    else if (change == 0)
            //    {
            //        Console.WriteLine($"Here is your {sweetness} {drink}. Enjoy!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"This drink costs {price}$. You need {Math.Abs(change)}$ more to buy this coffee. Add money.");
            //        string inputMoreMoney = Console.ReadLine();
            //        double moreMoney;
            //        bool moreMoneyParsed = double.TryParse(inputMoreMoney, out moreMoney);

            //        if (moreMoneyParsed)
            //        {
            //            if (moreMoney > Math.Abs(change))
            //            {
            //                Console.WriteLine($"Here is your {sweetness} {drink}, your change is {moreMoney - Math.Abs(change)}$. Enjoy!");

            //            } 
            //            else if (moreMoney >= Math.Abs(change))
            //            {
            //                Console.WriteLine($"Here is your {sweetness} {drink}. Enjoy!");

            //            }
            //            else
            //            {
            //                Console.WriteLine($"Sorry, it looks like you don't enough money. Here are your {money + moreMoney}$ back.");
            //            }
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input. Restart the program and try again.");

            //}



            //9. FUTURE PREDICTION =============================================



            //Random rnd = new Random();
            //int prediction = rnd.Next(1, 5);

            //switch (prediction)
            //{
            //    case 1:
            //        Console.WriteLine("You got a jackpot of 1.000.000EUR!");
            //        break;

            //    case 2:
            //        Console.WriteLine("You will lost weight.");
            //        break;

            //    case 3:
            //        Console.WriteLine("Your boyfriend will break up with you!");
            //        break;

            //    case 4:
            //        Console.WriteLine("Your cousin will buy you a dog!");
            //        break;

            //    case 5:
            //        Console.WriteLine("You will live 100 years!");
            //        break;

            //    default:
            //        Console.WriteLine("Our app is not working, please try again later.");
            //        break;
            //}



            //10. CELSIUS TO KELVIN & FARENHEIT CONVERTOR ======================



            //Console.WriteLine("Enter the celsius degree:");
            //string input = Console.ReadLine();
            //double celsius;
            //bool inputParsed = Double.TryParse(input, out celsius);


            //double kelvin = celsius + 273.15;
            //double farenheit = (celsius * 9 / 5) + 32;

            //if (inputParsed)
            //{
            //    Console.WriteLine($"{celsius}°C is equal to {kelvin}K and {farenheit}°F.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Restart the program and try again");
            //}







            Console.ReadLine();
        }
    }
}
