using System.Drawing;

namespace Monopoly.Model;

public class MapClassic
{
    private static readonly District[] Districts =
    {
        new District(Color.SaddleBrown)
            .Append("Житная", new (60, 30, 33), new (50, 50), new (2, 4, 10, 30, 90, 160, 250))
            .Append("Нагатинская", new (60, 30, 33), new (50, 50), new (4, 8, 20, 60, 180, 320, 450)), 
        
        new District(Color.Gray)
            .Append("Варшавское шоссе", new (100, 50, 55), new (50, 50), new (6, 12, 30, 90, 270, 400, 550))
            .Append("Огарева", new (100, 50, 55), new (50, 50), new (6, 12, 30, 90, 270, 400, 550))
            .Append("Первая Парковая", new (120, 60, 66), new (50, 50), new (8, 16, 40, 100, 300, 450, 600)), 
        
        new District(Color.Purple)
            .Append("Полянка", new (140, 70, 77), new (100, 100), new (10, 20, 50, 150, 450, 625, 750))
            .Append("Сретенка", new (140, 70, 77), new (100, 100), new (10, 20, 50, 150, 450, 625, 750))
            .Append("Ростовская наб.", new (160, 80, 88), new (100, 100), new (12, 24, 60, 180, 500, 700, 900)), 
        
        new District(Color.Orange)
            .Append("Рязанский пр.", new (180, 90, 99), new (100, 100), new (14, 28, 70, 200, 550, 750, 950))
            .Append("Вавилова", new (180, 90, 99), new (100, 100), new (14, 28, 70, 200, 550, 750, 950))
            .Append("Рублевское", new (200, 100, 110), new (100, 100), new (16, 32, 80, 220, 600, 800, 1000)), 
        
        new District(Color.Red)
            .Append("Тверская", new (220, 110, 121), new (150, 150), new (18, 36, 90, 250, 700, 875, 1050))
            .Append("Пушкинская", new (220, 110, 121), new (150, 150), new (18, 36, 90, 250, 700, 875, 1050))
            .Append("Пл. Маяковского", new (240, 120, 132), new (150, 150), new (20, 40, 100, 300, 750, 925, 1100)),
        
        new District(Color.Yellow)
            .Append("Гурзинский Вал", new (260, 130, 143), new (150, 150), new (22, 44, 110, 330, 800, 975, 1150))
            .Append("Новинский бул.", new (260, 130, 143), new (150, 150), new (22, 44, 110, 330, 800, 975, 1150))
            .Append("Смоленская пл.", new (280, 140, 154), new (150, 150), new (24, 48, 120, 360, 850, 1025, 1200)),
        
        new District(Color.Green)
            .Append("Щусева", new (300, 150, 165), new (200, 200), new (26, 52, 130, 390, 900, 1100, 1275))
            .Append("Гоголевский бул.", new (300, 150, 165), new (200, 200), new (26, 52, 130, 390, 900, 1100, 1275))
            .Append("Кутузовский пр.", new (320, 160, 176), new (200, 200), new (28, 56, 150, 450, 1000, 1200, 1400)),
        
        new District(Color.Blue)
            .Append("Малая Бронная", new (350, 175, 193), new (200, 200), new (35, 70, 175, 500, 1100, 1300, 1500))
            .Append("Арбат", new (400, 200, 220), new (200, 200), new (50, 100, 200, 600, 1400, 1700, 2000))
    };

    private static readonly RailwayGroup Railways = new(
        "Рижская", 
        "Курская", 
        "Казанская", 
        "Ленинградская");

    private static Tax[] Taxes = 
    {
        new (200),
        new (100)
    };

    private static readonly Special[] Specials = 
    {
        new (SpecialEnum.Go),
        new (SpecialEnum.JailOrFree),
        new (SpecialEnum.Parking),
        new (SpecialEnum.Police)
    };

    private static readonly ManagementCompanyGroup ManagementCompanies = new(
        ManagementTypeEnum.Electro, 
        ManagementTypeEnum.Water);

    private static readonly Treasure[] Treasures = 
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
        Railways.Railways[0],
        Districts[1].Streets[0],
        Treasures[1],
        Districts[1].Streets[1],
        Districts[1].Streets[2],
        Specials[1],
        Districts[2].Streets[0],
        ManagementCompanies.ManagementCompanies[0],
        Districts[2].Streets[1],
        Districts[2].Streets[2],
        Railways.Railways[1],
        Districts[3].Streets[0],
        Treasures[2],
        Districts[3].Streets[1],
        Districts[3].Streets[2],
        Specials[2],
        Districts[4].Streets[0], 
        Treasures[3], 
        Districts[4].Streets[1],
        Districts[4].Streets[2],
        Railways.Railways[2],
        Districts[5].Streets[0],
        Districts[5].Streets[1],
        ManagementCompanies.ManagementCompanies[1], 
        Districts[5].Streets[2],
        Specials[3],
        Districts[6].Streets[0],
        Districts[6].Streets[1], 
        Treasures[4], 
        Districts[6].Streets[2],
        Railways.Railways[3],
        Treasures[5],
        Districts[7].Streets[0],  
        Taxes[1],  
        Districts[7].Streets[1]
    };
}