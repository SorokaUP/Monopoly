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
    private readonly District _district;
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
    public ushort CostPayment() 
        => _payInfoStreet.CostPayment;
    
    /// <summary>
    /// Цена закладки
    /// </summary>
    public ushort CostDown() 
        => _payInfoStreet.CostDown;

    /// <summary>
    /// Цена выкупа
    /// </summary>
    public ushort CostUp() 
        => _payInfoStreet.CostUp;

    /// <summary>
    /// Цена дома
    /// </summary>
    public ushort CostHouse() 
        => _payInfoStreet.CostHouse;

    /// <summary>
    /// Цена отеля
    /// </summary>
    public ushort CostHotel() 
        => _payInfoStreet.CostHotel;
    
    /// <summary>
    /// Текущий владелец
    /// </summary>
    private User? _owner;

    public User? Owner() 
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
    private readonly RentStreet _rent;

    public ushort Rent()
    {
        throw new NotImplementedException();
    }

    private readonly PayInfoStreet _payInfoStreet;

    public Street(string name, PayInfoStreet payInfoStreet, RentStreet rent, District district)
    {
        this._name = name;
        this._district = district;
        this._enabled = true;
        this._homeCount = 0;
        this._owner = null;
        this._payInfoStreet = payInfoStreet;
        this._rent = rent;
    }
}