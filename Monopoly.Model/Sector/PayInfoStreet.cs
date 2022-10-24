namespace Monopoly.Model;

public record PayInfoStreet(
    ushort CostPayment,
    ushort CostDown,
    ushort CostUp,
    ushort CostHouse,
    ushort CostHotel);