namespace Monopoly.Model;

public class Tax : ISector
{
    /// <summary>
    /// Сумма налога
    /// </summary>
    private int _cost;

    public int Cost 
        => _cost;

    public Tax(int cost)
    {
        this._cost = cost;
    }
}