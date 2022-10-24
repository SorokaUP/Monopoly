namespace Monopoly.Model;

public class Street : ISector, IStreet
{
    /// <summary>
    /// Наименование
    /// </summary>
    private readonly string _name;

    public string Name
        => _name;
        
    /// <summary>
    /// Район
    /// </summary>
    private District _district;

    public void SetDistrict(District district)
    {
        this._district = district;
    }

    public District District()
        => _district;
    
    /// <summary>
    /// Улици НЕ заложена
    /// </summary>
    private bool _enabled;

    public bool Enabled()
        => _enabled;
    
    /// <summary>
    /// Цена покупки
    /// </summary>
    private ushort _cost;

    public ushort CostPayment() 
        => _cost;
    
    /// <summary>
    /// Цена закладки
    /// </summary>
    private ushort _costDown;

    public ushort CostDown() 
        => _costDown;

    /// <summary>
    /// Цена выкупа
    /// </summary>
    private ushort _costUp;

    public ushort CostUp() 
        => _costUp;

    /// <summary>
    /// Цена дома
    /// </summary>
    private ushort _costHouse;

    public ushort CostHouse() 
        => _costHouse;

    /// <summary>
    /// Цена отеля
    /// </summary>
    private ushort _costHotel;

    public ushort CostHotel() 
        => _costHotel;
    
    /// <summary>
    /// Текущий владелец
    /// </summary>
    private User _owner;

    public User Owner() 
        => _owner;

    /// <summary>
    /// Кол-во домов (0-4 | 5)
    /// </summary>
    private byte _homeCount;

    public byte HomeCount() 
        => _homeCount;

    /// <summary>
    /// Рента по кол-ву домов на улице
    /// </summary>
    private readonly ushort[] _rentArr;

    public ushort Rent()
    {
        throw new NotImplementedException();
    }

    public Street(string name, ushort cost, ushort costDown, ushort costRedemption, ushort costHouse, ushort costHotel, ushort[] rentArr)
    {
        this._name = name;
        this._district = null;
        this._enabled = true;
        this._homeCount = 0;
        this._owner = null;
        this._cost = cost;
        this._costDown = costDown;
        this._costUp = costRedemption;
        this._costHouse = costHouse;
        this._costHotel = costHotel;
        this._rentArr = rentArr;
    }
}