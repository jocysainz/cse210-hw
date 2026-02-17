using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int totalPoints = GetPoints();

            if (_amountCompleted == _target)
            {
                totalPoints += _bonus;
            }

            return totalPoints;
        }

        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStatus()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] Completed {_amountCompleted}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
