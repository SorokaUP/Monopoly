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
    private User _owner;
    
    /// <summary>
    /// Собственность НЕ заложена
    /// </summary>
    private bool _enabled;
    
    /// <summary>
    /// Цена покупки
    /// </summary>
    private const int _COST_PAYMENT = 200;
    
    /// <summary>
    /// Цена закладки
    /// </summary>
    private const int _COST_DOWN = 100;
    
    /// <summary>
    /// Цена выкупа
    /// </summary>
    private const int _COST_UP = 110;

    /// <summary>
    /// Рента по кол-ву выкупленных жд станций
    /// </summary>
    private readonly ushort[] _RENT = new ushort[] { 25, 50, 100, 200 };

    public Railway(string name)
    {
        this._name = name;
        this._enabled = true;
        this._owner = null;
    }

    public User Owner()
        => _owner;

    public bool Enabled()
        => _enabled;

    public ushort CostPayment()
        => _COST_PAYMENT;

    public ushort CostDown()
        => _COST_DOWN;

    public ushort CostUp()
        => _COST_UP;

    public ushort Rent()
    {
        throw new NotImplementedException();
    }
}