using UnityEngine;

public class InputListener : MonoBehaviour
{
    private Game _game;

    public void Initialize(Game game)
    {
        _game = game;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _game.EndGame();
        }
    }
}