using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;

public class Game
{
    private Score _score;

    public Game(Score score)
    {
        _score = score;
        StartGame();
    }

    private void StartGame()
    {
        _score.CurrentScore = 5;
    }

    public void EndGame()
    {
        _score.CurrentScore = 0;
        Application.Quit();
    }
}