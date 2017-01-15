namespace OOPFromScratch.Engine.Factories
{
    using OOPFromScratch.Interfaces;
    using OOPFromScratch.Interfaces.Engine;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registratinonNumber)
        {
            return new Company(name, registratinonNumber);
        }
    }
}
