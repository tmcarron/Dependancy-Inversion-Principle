using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Inversion_Principle
{
    public class Emailer : IEmailer
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Sending email to {person.EmailAddress}");
        }
    }
}
