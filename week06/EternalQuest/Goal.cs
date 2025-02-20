public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] - {_shortName} - {_description} - {_points}";
        }
        else
        {
            return $"[ ] - {_shortName} - {_description} - {_points}";
        }
    }

    public abstract string GetStringRepresentation();
}