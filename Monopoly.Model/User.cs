namespace Monopoly.Model;

public class User
{
    private ISector _currentPosition;
    private int _money;
    private FigureEnum _figure;
    private IList<ISector> _ownership;
}