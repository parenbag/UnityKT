using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    private Score _score;

    public void Initialize(Score score)
    {
        _score = score;
        _score.OnScoreChanged += UpdateScoreDisplay;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + _score.CurrentScore;
    }
}