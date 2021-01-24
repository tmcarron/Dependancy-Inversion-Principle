using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Inversion_Principle
{
    class Chore : IChore
    {
        //Interfaces represented as fields
        ILogger _logger;
        IEmailer _emailer;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        //passing in the interfaces I need through the constructor
        public Chore(ILogger log, IEmailer emailer)
        {
            _logger = log;
            _emailer = emailer;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");

        }
        public void CompletChore()
        {
            IsComplete = true;   
            _logger.Log($"Completed {ChoreName}");

            _emailer.SendEmail(Owner, $"The chore {ChoreName} is complete");
        }
    }
}
