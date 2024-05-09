using System;
using System.Collections;
using System.Collections.Generic;
using Game.Components;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image _fillImage;

    public void OnHealthChanged(float health, float maxHealth)
    {
        _fillImage.fillAmount = health / maxHealth;
    }
}
