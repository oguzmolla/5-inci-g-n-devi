using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);

            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Oğzuhan",
                LastName = "Molla",
                BirthYear = 2006,
                IdentityNumber = 2146832092
            };

            gamerManager.Add(gamer);

            //Console.WriteLine("Hello World!");
        }
    }
}
