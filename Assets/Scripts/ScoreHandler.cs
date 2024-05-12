using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public int Score { get; private set; }
    public TextMeshProUGUI _scoreDisplay;

    private void IncrementScore(float _)
    {
        Score++;
        _scoreDisplay.text = $"{Score:000}";
    }
}
