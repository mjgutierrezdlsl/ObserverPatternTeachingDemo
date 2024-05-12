using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public int Score { get; private set; }
    public TextMeshProUGUI _scoreDisplay;

    public void IncrementScore()
    {
        Score++;
        _scoreDisplay.text = $"{Score:000}";
    }
}
