using Homework5_Classes.Domain;
using Homework5_Classes.Services;
using System;

namespace Homework5_Classes
{
    class Program
    {
       
        private static AnimalService _animalService = new AnimalService();
        private static HelperService _helperService = new HelperService();
        private static OwnerService _ownerService = new OwnerService();
        private static Owner _registeredOwner = null;
        private static Owner _adoptedPets = null;
        

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to our Pet Shelter.");
                Console.WriteLine("To registrate please enter your first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your city:");
                string city = Console.ReadLine();
                Console.WriteLine("Enter your address:");
                string address = Console.ReadLine();

                Owner newOwner = new Owner(firstName, lastName, city, address);
                _registeredOwner = _ownerService.Register(newOwner);

                Console.Clear();
                Console.WriteLine($"Hello {newOwner.FirstName}. Tell us how old are you?");
                string inputYears = Console.ReadLine();
                int years;
                bool inputYearsParsed = Int32.TryParse(inputYears, out years);

                if (_registeredOwner == null || !inputYearsParsed)
                {
                    Console.WriteLine("There has been a problem with the registration! Please try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (inputYearsParsed && years < 18)
                {
                    Console.WriteLine("Sorry. It seems like you are not old enough to adopt a pet :( .");
                    break;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Cool. You are ready to adopt a pet!");
                    Console.WriteLine(@"This is our list for pets which you can choose from by writing their number and pressing enter. You can adopt multiple pets! Enter ""N"" to stop!");

                    int counter = 1;
                    foreach (Animal animal in _animalService.Animals)
                    {
                        Console.WriteLine($"{counter}. {animal.Name} the {animal.Specie}");
                        counter++;
                    }

                    string inputNumber = Console.ReadLine();
                    int number;
                    bool inputNumberParsed = Int32.TryParse(inputNumber, out number);

                    //while (inputNumberParsed)
                    //{
                    //    switch (number)
                    //    {
                    //        case 1:

                    //        default:
                    //            break;
                    //    }
                    //}




                }


                break;


            }

        }
    }
}
