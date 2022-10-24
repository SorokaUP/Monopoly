namespace Monopoly.Model;

public class Special : ISector
{
    private SpecialEnum _type;

    public SpecialEnum SpecialType
        => _type;

    public Special(SpecialEnum type)
    {
        this._type = type;
    }
}