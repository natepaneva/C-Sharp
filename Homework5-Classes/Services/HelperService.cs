using System;
using Homework5_Classes.Domain;

namespace Homework5_Classes.Services
{
    public class HelperService
    {
        public bool ValidateStringLength(string value, int range)
        {
            int maxLength = 20;
            if (value.Length < range && range < maxLength)
                return false;
            return true;
        }
    }
}
