using System;

namespace Exercises.Algorithms.Codewars.TotalAmountOfPoints;

public class TotalAmountOfPoints
{
    public int TotalPoints(string[] games)
    {
        int total = 0;
        for (int i = 0; i < games.Length; i++)
        {
            string[] matchScore = games[i].Split(':');
            int ourTeamsGoals = Convert.ToInt32(matchScore[0]);
            int opponentsGoals = Convert.ToInt32(matchScore[1]);
            if (ourTeamsGoals > opponentsGoals)
            {
                total += 3;
            }
            if (ourTeamsGoals == opponentsGoals)
            {
                total++;
            }
        }
        return total;
    }
}
