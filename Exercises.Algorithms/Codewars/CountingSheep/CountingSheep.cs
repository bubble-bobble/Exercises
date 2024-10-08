namespace Exercises.Algorithms.Codewars.CountingSheep;

public class CountingSheep
{
    public int Count(bool[] sheeps)
    {
        int quantity = 0;
        for (int i = 0; i < sheeps.Length; i++)
        {
            if (sheeps[i])
            {
                quantity++;
            }
        }
        return quantity;
    }
}
