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

    public District(Color color, params Street[] streets)
    {
        foreach (var street in streets)
        {
            _streets.Add(street);
        }
    }

    /// <summary>
    /// Выкуплено полностью
    /// </summary>
    public bool Redeemed()
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
                return false;
            }
        }

        return user != null;
    }
}