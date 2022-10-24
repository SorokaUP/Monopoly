namespace Monopoly.Model;

public interface IPayment
{
    /// <summary>
    /// Текущий владелец
    /// </summary>
    User Owner();
    
    /// <summary>
    /// Собственность НЕ заложена
    /// </summary>
    bool Enabled();
    
    /// <summary>
    /// Цена покупки
    /// </summary>
    ushort CostPayment();
    
    /// <summary>
    /// Цена закладки
    /// </summary>
    ushort CostDown();

    /// <summary>
    /// Цена выкупа
    /// </summary>
    ushort CostUp();

    /// <summary>
    /// Рента
    /// </summary>
    ushort Rent();
}