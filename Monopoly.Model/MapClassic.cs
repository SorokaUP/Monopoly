using System.Drawing;

namespace Monopoly.Model;

public class MapClassic
{
    private static District[] Districts =
    {
        new District(Color.SaddleBrown)
            .Append("Житная", new (60, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Нагатинская", new (60, 30, 33, 50, 50), new (4, 8, 20, 60, 180, 320, 450)), 
        
        new District(Color.Gray)
            .Append("Варшавское шоссе", new (100, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Огарева", new (100, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Первая Парковая", new (120, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0)), 
        
        new District(Color.Purple)
            .Append("Полянка", new (140, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Сретенка", new (140, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Ростовская наб.", new (160, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0)), 
        
        new District(Color.Orange)
            .Append("Рязанский пр.", new (180, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Вавилова", new (180, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Рублевское", new (200, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0)), 
        
        new District(Color.Red)
            .Append("Тверская", new (220, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Пушкинская", new (220, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Пл. Маяковского", new (240, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0)),
        
        new District(Color.Yellow)
            .Append("Гурзинский Вал", new (260, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Новинский бул.", new (260, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Смоленская пл.", new (280, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0)),
        
        new District(Color.Green)
            .Append("Щусева", new (300, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Гоголевский бул.", new (300, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Кутузовский пр.", new (320, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0)),
        
        new District(Color.Blue)
            .Append("Малая Бронная", new (350, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
            .Append("Арбат", new (400, 0, 0, 0, 0), new (0, 0, 0, 0, 0, 0, 0))
    };

    private static Railway[] Railways =
    {
        new ("Рижская"),
        new ("Курская"),
        new ("Казанская"), 
        new ("Ленинградская")
    };

    private static Tax[] Taxes = 
    {
        new (200),
        new (100)
    };

    private static Special[] Specials = 
    {
        new (SpecialEnum.Go),
        new (SpecialEnum.JailOrFree),
        new (SpecialEnum.Parking),
        new (SpecialEnum.Police)
    };

    private static ManagementCompany[] ManagementCompanies = 
    {
        new (ManagementTypeEnum.Electro), 
        new (ManagementTypeEnum.Water)
    };

    private static Treasure[] Treasures = 
    {
        new (TreasureTypeEnum.Treasure),
        new (TreasureTypeEnum.Chance),
        new (TreasureTypeEnum.Treasure),
        new (TreasureTypeEnum.Chance),
        new (TreasureTypeEnum.Treasure),
        new (TreasureTypeEnum.Chance),
    };
    
    private ISector[] _sectors = 
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