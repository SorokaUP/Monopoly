namespace Monopoly.Model;

public class ManagementCompanyGroup
{
    private readonly IList<ManagementCompany> _managementCompanies = new List<ManagementCompany>();
    public IList<ManagementCompany> ManagementCompanies 
        => _managementCompanies;

    public ManagementCompanyGroup(params ManagementTypeEnum[] managementTypes)
    {
        foreach (var managementType in managementTypes)
        {
            _managementCompanies.Add(new (managementType, this));
        }
    }
}