namespace Monopoly.Model;

public class ManagementCompany : ISector, IPayment
{
    private readonly ManagementTypeEnum _type;

    public ManagementTypeEnum ManagementType 
        => _type;

    private ManagementCompanyGroup _group;

    public ManagementCompany(ManagementTypeEnum type, ManagementCompanyGroup group)
    {
        this._type = type;
        this._owner = null;
        this._enabled = true;
        this._group = group;
    }

    private User _owner;

    public User Owner()
        => _owner;

    private bool _enabled;

    public bool Enabled()
        => _enabled;

    private readonly PayInfo _payInfo = new (150, 75, 83);

    public ushort CostPayment()
        => _payInfo.CostPayment;

    public ushort CostDown()
        => _payInfo.CostDown;

    public ushort CostUp()
        => _payInfo.CostUp;

    private readonly RentManagementCompany _rent = new (4, 10);
    public ushort Rent()
    {
        throw new NotImplementedException();
    }
}