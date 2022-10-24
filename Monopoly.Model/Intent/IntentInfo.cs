namespace Monopoly.Model;

public class IntentInfo
{
    private string _descripton;
    public string Discription => _descripton;

    private IIntent _intent;
    public IIntent Intent => _intent;

    public IntentInfo(string descripton, IIntent intent)
    {
        this._descripton = descripton;
        this._intent = intent;
    }
}