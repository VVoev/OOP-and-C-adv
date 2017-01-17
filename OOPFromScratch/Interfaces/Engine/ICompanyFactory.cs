namespace OOPFromScratch.Interfaces.Engine
{
    public interface ICompanyFactory
    {
        ICompany CreateCompany(string name, string registratinonNumber);
    }
}
