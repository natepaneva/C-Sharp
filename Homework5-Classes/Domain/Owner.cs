using System;

namespace Homework5_Classes.Domain
{
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Animal[] Pets { get; set; }
        public string City { get; set; }


        public string FullInfo()
        {
            return $"{FirstName} {LastName}, lives in the city of {City} on address {Address}";
        }


        public Owner(string firstName, string lastName, string city, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Address = adress;
            Pets = new Animal[0];

        }

        

        
    }
   
}
