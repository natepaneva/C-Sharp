using System;
using Homework5_Classes.Domain;


namespace Homework5_Classes.Services
{
    public class OwnerService
    {

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

        //public Owner PetsAdopted(Owner[] Pets)
        //{
        //    if (!_helperService.ValidateNumber(1, 5) ||
        //        !_helperService.ValidateNumber(2, 5) ||
        //        !_helperService.ValidateNumber(3, 5) ||
        //        !_helperService.ValidateNumber(1, 5) ||
        //        !_helperService.ValidateNumber(1, 5))
        //    {
        //        return null;
        //    }

        //    Pets[] newArr = Pets
        //}
        
    }
}
