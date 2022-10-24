namespace Monopoly.Model;

public class Treasure : ISector
{
    private readonly TreasureTypeEnum _type;

    public TreasureTypeEnum TreasureType 
        => _type;

    public Treasure(TreasureTypeEnum type)
    {
        this._type = type;
    }
}