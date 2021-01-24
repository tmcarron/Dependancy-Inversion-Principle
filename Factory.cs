using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Inversion_Principle
{
    //A class that holds all of the objects I don't want the main method to be dependant on
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateEmailer());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IEmailer CreateEmailer()
        {
            return new Emailer();
        }
    }
}
