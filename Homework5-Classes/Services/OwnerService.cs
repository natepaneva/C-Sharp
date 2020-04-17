using System;
using Homework5_Classes.Domain;
using Homework5_Classes.Services;


namespace Homework5_Classes.Services
{
    public class OwnerService
    {

        public Owner[] owners = new Owner[0]
        {


        };

        private HelperService _helperService = new HelperService();
        public Owner[] Owners { get; set; }
        
        public OwnerService()
        {
            Owners = new Owner[0];
            
        }

        public Owner Register(Owner owner)
        {
            if (!_helperService.ValidateStringLength(owner.FirstName, 2) ||
                !_helperService.ValidateStringLength(owner.LastName, 2) ||
               !_helperService.ValidateStringLength(owner.City, 3) ||
               !_helperService.ValidateStringLength(owner.Address, 5))
            {
                return null;
            }

            Owner[] newArr = Owners;
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[newArr.Length - 1] = owner;
            Owners = newArr;

            return Owners[Owners.Length - 1];
        }


        public string AdoptAnimal(Animal animal, Owner owner, int indexNum)
        {

            Animal[] adoptedPets = owner.Pets;

            Array.Resize(ref adoptedPets, adoptedPets.Length + 1);
            adoptedPets[adoptedPets.Length - 1] = animal;
            owner.Pets = adoptedPets;

            return adoptedPets[indexNum - 1].Name;
        }

    }
}
