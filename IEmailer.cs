namespace Dependancy_Inversion_Principle
{
    public interface IEmailer
    {
        void SendEmail(IPerson person, string message);
    }
}