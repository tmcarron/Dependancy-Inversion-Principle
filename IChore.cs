namespace Dependancy_Inversion_Principle
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompletChore();
        void PerformedWork(double hours);
    }
}