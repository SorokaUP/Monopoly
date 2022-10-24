namespace Monopoly.Model;

public class ManagementCompany : ISector, IPayment
{
    private readonly ManagementTypeEnum _type;

    public ManagementTypeEnum ManagementType 
        => _type;

    public ManagementCompany(ManagementTypeEnum type)
    {
        this._type = type;
        this._owner = null;
        this._enabled = true;
    }

    private User _owner;

    public User Owner()
        => _owner;

    private bool _enabled;

    public bool Enabled()
        => _enabled;

    private const ushort _COST_PAYMENT = 150;

    public ushort CostPayment()
        => _COST_PAYMENT;

    private const ushort _COST_DOWN = 75;

    public ushort CostDown()
        => _COST_DOWN;

    private const ushort _COST_UP = 83;

    public ushort CostUp()
        => _COST_UP;

    public ushort Rent()
    {
        throw new NotImplementedException();
    }
}