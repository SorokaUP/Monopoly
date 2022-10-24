namespace Monopoly.Model;

public class RailwayGroup
{
    private IList<Railway> _railways = new List<Railway>();
    public IList<Railway> Railways 
        => _railways;

    public RailwayGroup(params string[] names)
    {
        foreach (var name in names)
        {
            _railways.Add(new (name, this));
        }
    }
    
    /// <summary>
    /// Выкуплено полностью
    /// </summary>
    public User? AllPaymentUser()
    {
        User? user = null;
        foreach (var railway in _railways)
        {
            if (railway.Owner() == null)
            {
                return null;
            }
            
            if (user == null)
            {
                user = railway.Owner();
                continue;
            }

            if (user != railway.Owner())
            {
                return null;
            }
        }

        return user;
    }
}