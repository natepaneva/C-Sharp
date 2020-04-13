using System;

namespace Homework5_Classes.Domain
{
    public class Animal
    {
        public string Name { get; set; }
        public string Specie { get; set; }
        public string Color { get; set; }
        public string[] FavoriteFoods { get; set; }
        public Owner Owner { get; set; }


        public string Eat(string food)
        {
            return $"{Name} the {Specie} wants to eat {food}";
        }


        public string Sleep(int from, int till)
        {
            return $"{Name} the {Specie} wants to sleep from {from} till {till}";
        }

        public Animal()
        {
            FavoriteFoods = new string[2] { "Meat", "Snacks"};
        }

        public Animal(string petName, string petSpecie, string petColor)
        {
            Name = petName;
            Specie = petSpecie;
            Color = petColor;
        }

    }
}

