namespace Monopoly.Model;

public interface IStreet : IPayment
{
    /// <summary>
    /// Район
    /// </summary>
    District District();
    
    /// <summary>
    /// Цена дома
    /// </summary>
    ushort CostHouse();

    /// <summary>
    /// Цена отеля
    /// </summary>
    ushort CostHotel();
}