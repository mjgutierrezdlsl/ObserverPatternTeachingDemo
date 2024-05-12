using TMPro;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinDisplay;
    [SerializeField] AudioHandler _audioHandler;
    [SerializeField] Bounce _bounceAnimation;
    public float Amount { get; private set; }

    public void AddCoins(float amount)
    {
        Amount += amount;
        _coinDisplay.text = $"{Amount:000}";
        _audioHandler.PlayRandomClip();
        _bounceAnimation.Click(0.95f);
    }
}
