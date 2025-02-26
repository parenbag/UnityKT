using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    private Score _score;

    public void Initialize(Score score)
    {
        _score = score;
    }

    void OnMouseDown()
    {
        _score.ChangeScore(-1);
    }
}