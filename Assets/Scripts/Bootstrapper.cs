
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public GameObject clickableObject;
    public GameObject movingObject;
    public InputListener inputListener;
    public ScoreDisplay scoreDisplay;

    private Game _game;
    private Score _score;

    void Start()
    {
        _score = new Score();
        _game = new Game(_score);

        inputListener.Initialize(_game);
        scoreDisplay.Initialize(_score);

        var clickable = clickableObject.GetComponent<ClickableObject>();
        clickable.Initialize(_score);

        var moving = movingObject.GetComponent<MovingObject>();
        moving.Initialize(_score);
    }
}