using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinDisplay;
    [SerializeField] AudioHandler _audioHandler;
    [SerializeField] Bounce _bounceAnimation;
    private float _amount;
    public void UpdateDisplay(float amount)
    {
        _amount += amount;
        _coinDisplay.text = $"{_amount:000}";
        _audioHandler.PlayRandomClip();
        _bounceAnimation.Click(0.95f);
    }
}
