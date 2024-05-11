using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private float _maxHealth;
    private float _currentHealth;
    private float _coinAmount;


    public UnityEvent onInit;
    public UnityEvent<float> onDespawn;
    [SerializeField] private UnityEvent<float, float> DamageTaken;

    public void Despawn(bool sendEvent = true)
    {
        transform.DOScale(0f, 0.5f).From(1f).SetEase(Ease.OutBounce);
        gameObject.SetActive(false);
        if (!sendEvent) { return; }
        onDespawn?.Invoke(_coinAmount);
    }

    public void Init(EnemyData data)
    {
        _maxHealth = data.MaxHealth;
        _currentHealth = _maxHealth;
        _renderer.sprite = data.Sprite;
        _coinAmount = data.CoinAmount;

        gameObject.SetActive(true);
        onInit?.Invoke();
    }

    public void TakeDamage(int damageAmount)
    {
        _currentHealth -= damageAmount;
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            onDespawn?.Invoke(_coinAmount);
        }
        DamageTaken?.Invoke(_currentHealth, _maxHealth);
        _renderer.DOColor(Color.white, 0.5f).From(Color.red);
    }
}
