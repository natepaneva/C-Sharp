using System;
using Homework5_Classes.Domain;

namespace Homework5_Classes.Services
{
    public class AnimalService
    {
        public Animal[] Animals { get; set; }

        public Animal[] petShelter = new Animal[]
        {
            new Animal()
            {
                 Name = "Boogie",
                Specie = "dog",
                Color = "white"
            },

            new Animal()
            {
                Name = "Misha",
                Specie = "cat",
                Color = "white"
            },

            new Animal()
            {
                Name = "Coco",
                Specie = "parrot",
                Color = "blue"
            },

            new Animal()
            {
                Name = "Roki",
                Specie = "dog",
                Color = "black"
            },

            new Animal()
            {
                Name = "Cheetah",
                Specie = "cat",
                Color = "yellow"
            }
        };

        public static Animal FindPet(Animal[] pets, int index)
        {
            return pets[index - 1];
        }
        //public AnimalService()
        //{

        //Animals = new Animal[]
        //{
        //new Animal()
        //{
        //    Name = "Boogie",
        //    Specie = "dog",
        //    Color = "white"

        //},

        //new Animal()
        //{
        //    Name = "Misha",
        //    Specie = "cat",
        //    Color = "white"
        //},

        //new Animal()
        //{
        //    Name = "Coco",
        //    Specie = "parrot",
        //    Color = "blue"
        //},

        //new Animal()
        //{
        //    Name = "Roki",
        //    Specie = "dog",
        //    Color = "black"
        //},

        //new Animal()
        //{
        //    Name = "Cheetah",
        //    Specie = "cat",
        //    Color = "yellow"
        //}

        //};
        //}
    }
}


//public AnimalService()
//{
//    Animal boogie = new Animal
//    {
//        Name = "Boogie",
//        Specie = "dog",
//        Color = "white"
//    };

//    Animal misha = new Animal
//    {
//        Name = "Misha",
//        Specie = "cat",
//        Color = "white"
//    };

//    Animal coco = new Animal
//    {
//        Name = "Coco",
//        Specie = "parrot",
//        Color = "blue"
//    };

//    Animal roki = new Animal
//    {
//        Name = "Roki",
//        Specie = "dog",
//        Color = "black"
//    };

//    Animal chetaah = new Animal
//    {
//        Name = "Cheetah",
//        Specie = "cat",
//        Color = "yellow"
//    };

//}

//Animal[] animals = new Animal() { boogie, misha, coco, roki, cheetah };
