namespace Monopoly.Model;

public class Railway : ISector, IPayment
{
    /// <summary>
    /// Наименование
    /// </summary>
    private string _name;

    public string Name()
        => _name;
    
    /// <summary>
    /// Владелец
    /// </summary>
    private User? _owner;
    
    /// <summary>
    /// Собственность НЕ заложена
    /// </summary>
    private bool _enabled;
    
    /// <summary>
    /// Стоимости имущества
    /// </summary>
    private readonly PayInfo _payInfo = new(200, 100, 110);

    /// <summary>
    /// Рента по кол-ву выкупленных жд станций
    /// </summary>
    private readonly RentRailway _rent = new (25, 50, 100, 200);

    public Railway(string name, RailwayGroup group)
    {
        this._name = name;
        this._enabled = true;
        this._owner = null;
        this._group = group;
    }

    private readonly RailwayGroup _group;

    public User? Owner()
        => _owner;

    public bool Enabled()
        => _enabled;

    /// <summary>
    /// Цена покупки
    /// </summary>
    public ushort CostPayment()
        => _payInfo.CostPayment;

    /// <summary>
    /// Цена закладки
    /// </summary>
    public ushort CostDown()
        => _payInfo.CostDown;

    /// <summary>
    /// Цена выкупа
    /// </summary>
    public ushort CostUp()
        => _payInfo.CostUp;

    public ushort Rent()
    {
        var user = _group.AllPaymentUser();
        if (user != null)
        {
            return _rent.WithAll;
        }

        throw new NotImplementedException();
    }
}