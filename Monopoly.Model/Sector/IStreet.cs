namespace Monopoly.Model;

public interface IStreet : IPayment
{ 
    /// <summary>
    /// Прописать район
    /// </summary>
    void SetDistrict(District district);
    
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