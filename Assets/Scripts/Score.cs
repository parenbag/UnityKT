using System;

public class Score
{
    public int CurrentScore { get; set; }
    public Action OnScoreChanged;

    public void ChangeScore(int amount)
    {
        CurrentScore += amount;
        OnScoreChanged?.Invoke();
    }
}