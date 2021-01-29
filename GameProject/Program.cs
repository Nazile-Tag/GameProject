using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "NAZİLE", LastName = "TAĞ", BirthYear = 1988, IdentityNumber = 12345678910 });
        }
    }
}
