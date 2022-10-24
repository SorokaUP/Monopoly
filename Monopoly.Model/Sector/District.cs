using System.Drawing;

namespace Monopoly.Model;

public class District
{
    /// <summary>
    /// Цвет улиц на районе
    /// </summary>
    private readonly Color _color;

    public Color Color 
        => _color;

    /// <summary>
    /// Улицы на районе
    /// </summary>
    private readonly IList<Street> _streets = new List<Street>();

    public IList<Street> Streets 
        => _streets;

    public District(Color color)
    {
        this._color = color;
    }

    public District Append(string name, PayInfoStreet payInfoStreet, RentStreet rent)
    {
        _streets.Add(new (name, payInfoStreet, rent, this));
        return this;
    }

    /// <summary>
    /// Выкуплено полностью
    /// </summary>
    public User? Redeemed()
    {
        User? user = null;
        foreach (var street in _streets)
        {
            if (user == null)
            {
                user = street.Owner();
                continue;
            }

            if (user != street.Owner())
            {
                return null;
            }
        }

        return user;
    }
}