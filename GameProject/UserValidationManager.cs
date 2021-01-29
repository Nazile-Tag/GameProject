using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="NAZİLE" && gamer.LastName=="TAĞ" && gamer.BirthYear==1988 && gamer.IdentityNumber==12345678910 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
