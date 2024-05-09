using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Game.Components;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Entities
{
    [RequireComponent(typeof(Health))]
    public class Enemy : MonoBehaviour
    {
        Health _health;
        Audio _audio;
        SpriteRenderer _sprite;

        [SerializeField] Sprite[] _sprites;
        [SerializeField] AudioClip[] _damageClips, _coinClips, _spawnClips;
        //TODO: Explain differences between UnityEvents and C# events
        [SerializeField] UnityEvent<float, float> onHealthValueChanged;

        void Awake()
        {
            _health = GetComponent<Health>();
            _audio = GetComponent<Audio>();
            _sprite = GetComponent<SpriteRenderer>();
        }

        void Start()
        {
            _sprite.sprite = _sprites[UnityEngine.Random.Range(0, _sprites.Length)];
            _health.ResetHealth();
        }

        void OnEnable()
        {
            _health.OnValueChanged += OnHealthValueChanged;
            _health.OnHealthDepleted += OnHealthDepleted;
        }

        void OnDisable()
        {
            _health.OnValueChanged -= OnHealthValueChanged;
            _health.OnHealthDepleted -= OnHealthDepleted;
        }

        private void OnHealthDepleted()
        {
            _audio.PlayRandomClip(_coinClips);
            _audio.PlayRandomClip(_spawnClips);
            _sprite.sprite = _sprites[UnityEngine.Random.Range(0, _sprites.Length)];
            _health.ResetHealth();
        }

        private void OnHealthValueChanged(float health)
        {
            if (health < _health.MaxHealth)
            {
                _audio.PlayRandomClip(_damageClips);
            }

            onHealthValueChanged?.Invoke(health, _health.MaxHealth);
        }

        public void TakeDamage(int damageAmount)
        {
            transform.DOScale(1f, 0.5f).From(0.8f).SetEase(Ease.OutBounce);
            _sprite.DOColor(Color.white, 0.5f).From(Color.red).SetEase(Ease.OutBounce);
            _health.Value -= damageAmount;
        }
    }

}