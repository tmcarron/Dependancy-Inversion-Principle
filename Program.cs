using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstracting the person class by calling an interface. Using the factory method to instansiate it
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Tyler";
            owner.LastName = "Carron";
            owner.EmailAddress = "TMC@Gmail.com";
            owner.PhoneNumber = "444-444-4444";

            //Abstracting Chore class as well
            IChore chore = Factory.CreateChore();

            chore.ChoreName = "learning SOLID principles";
            chore.Owner = owner;
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompletChore();

        }
    }
}
