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

    /// <summary>
    /// Цена дома
    /// </summary>
    public ushort CostHouse() 
        => _payInfoHouse.CostHouse;

    /// <summary>
    /// Цена отеля
    /// </summary>
    public ushort CostHotel() 
        => _payInfoHouse.CostHotel;
    
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

    private readonly PayInfo _payInfo;
    private readonly PayInfoHouse _payInfoHouse;

    public Street(string name, PayInfo payInfo, PayInfoHouse payInfoHouse, RentStreet rent, District district)
    {
        this._name = name;
        this._district = district;
        this._enabled = true;
        this._homeCount = 0;
        this._owner = null;
        this._payInfo = payInfo;
        this._payInfoHouse = payInfoHouse;
        this._rent = rent;
    }
}