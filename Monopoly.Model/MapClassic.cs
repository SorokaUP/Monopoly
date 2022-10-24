using System.Drawing;

namespace Monopoly.Model;

public class MapClassic
{
    private static Street StreetBrown1 = new Street("Житная", 60, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0}); 
    private static Street StreetBrown2 = new Street("Нагатинская", 60, 30, 33, 50, 50, new ushort[] {4, 8, 20, 60, 180, 320, 450}); 
    private static District DistrictBrown = new District(Color.SaddleBrown, StreetBrown1, StreetBrown2);
    
    private static Street StreetGray1 = new Street("Варшавское шоссе", 100, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetGray2 = new Street("Огарева", 100, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetGray3 = new Street("Первая Парковая", 120, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictGray = new District(Color.Gray, StreetGray1, StreetGray2, StreetGray3);
    
    private static Street StreetPurple1 = new Street("Полянка", 140, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetPurple2 = new Street("Сретенка", 140, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetPurple3 = new Street("Ростовская наб.", 160, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictPurple = new District(Color.Purple, StreetPurple1, StreetPurple2, StreetPurple3);
    
    private static Street StreetOrange1 = new Street("Рязанский пр.", 180, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetOrange2 = new Street("Вавилова", 180, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetOrange3 = new Street("Рублевское", 200, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictOrange = new District(Color.Orange, StreetOrange1, StreetOrange2, StreetOrange3);
    
    private static Street StreetRed1 = new Street("Тверская", 220, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetRed2 = new Street("Пушкинская", 220, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetRed3 = new Street("Пл. Маяковского", 240, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictRed = new District(Color.Red, StreetRed1, StreetRed2, StreetRed3);
    
    private static Street StreetYellow1 = new Street("Гурзинский Вал", 260, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetYellow2 = new Street("Новинский бул.", 260, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetYellow3 = new Street("Смоленская пл.", 280, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictYellow = new District(Color.Yellow, StreetYellow1, StreetYellow2, StreetYellow3);
    
    private static Street StreetGreen1 = new Street("Щусева", 300, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetGreen2 = new Street("Гоголевский бул.", 300, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetGreen3 = new Street("Кутузовский пр.", 320, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictGreen = new District(Color.Green, StreetGreen1, StreetGreen2, StreetGreen3);
    
    private static Street StreetBlue1 = new Street("Малая Бронная", 350, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static Street StreetBlue2 = new Street("Арбат", 400, 0, 0, 0, 0, new ushort[] {0, 0, 0, 0, 0, 0, 0});
    private static District DistrictBlue = new District(Color.Blue, StreetBlue1, StreetBlue2);

    private static District[] Districts = new[]
    {
        DistrictBrown, 
        DistrictGray, 
        DistrictPurple, 
        DistrictOrange, 
        DistrictRed, 
        DistrictYellow, 
        DistrictGreen, 
        DistrictBlue
    };

    private static Railway[] Railways = new[]
    {
        new Railway("Рижская"),
        new Railway("Курская"),
        new Railway("Казанская"), 
        new Railway("Ленинградская")
    };

    private static Tax[] Taxes = new[]
    {
        new Tax(200),
        new Tax(100)
    };

    private static Special[] Specials = new[]
    {
        new Special(SpecialEnum.Go),
        new Special(SpecialEnum.JailFree),
        new Special(SpecialEnum.Parking),
        new Special(SpecialEnum.Police)
    };

    private static ManagementCompany[] ManagementCompanies = new[]
    {
        new ManagementCompany(ManagementTypeEnum.Electro), 
        new ManagementCompany(ManagementTypeEnum.Water)
    };

    private static Treasure[] Treasures = new[]
    {
        new Treasure(TreasureTypeEnum.Treasure),
        new Treasure(TreasureTypeEnum.Chance),
        new Treasure(TreasureTypeEnum.Treasure),
        new Treasure(TreasureTypeEnum.Chance),
        new Treasure(TreasureTypeEnum.Treasure),
        new Treasure(TreasureTypeEnum.Chance),
    };
    
    private ISector[] _sectors = new ISector[]
    {
        Specials[0],
        Districts[0].Streets[0],
        Treasures[0],
        Districts[0].Streets[1],
        Taxes[0],
        Railways[0],
        Districts[1].Streets[0],
        Treasures[1],
        Districts[1].Streets[1],
        Districts[1].Streets[2],
        Specials[1],
        Districts[2].Streets[0],
        ManagementCompanies[0],
        Districts[2].Streets[1],
        Districts[2].Streets[2],
        Railways[1],
        Districts[3].Streets[0],
        Treasures[2],
        Districts[3].Streets[1],
        Districts[3].Streets[2],
        Specials[2],
        Districts[4].Streets[0], 
        Treasures[3], 
        Districts[4].Streets[1],
        Districts[4].Streets[2],
        Railways[2],
        Districts[5].Streets[0],
        Districts[5].Streets[1],
        ManagementCompanies[1], 
        Districts[5].Streets[2],
        Specials[3],
        Districts[6].Streets[0],
        Districts[6].Streets[1], 
        Treasures[4], 
        Districts[6].Streets[2],
        Railways[3],
        Treasures[5],
        Districts[7].Streets[0],  
        Taxes[1],  
        Districts[7].Streets[1]
    };
}