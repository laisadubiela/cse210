public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int Bonus => _bonus;
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] - {_shortName} - {_description} - {_points} --- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] - {_shortName} - {_description} - {_points} --- Currently completed {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}