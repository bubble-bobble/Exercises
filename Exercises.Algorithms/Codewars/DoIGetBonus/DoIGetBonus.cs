namespace Exercises.Algorithms.Codewars.DoIGetBonus;

public class DoIGetBonus
{
    public string BonusTime(int salary, bool bonus)
    {
        return bonus ? $"${salary * 10}" : $"${salary}";
    }
}
