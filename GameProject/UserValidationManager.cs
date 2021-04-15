using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear < 2002 && gamer.FirstName.Length > 2
                 && gamer.LastName.Length > 2 && gamer.IdentityNumber > 2)
            {
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine();
                return false;
            }

        }
    }
}
