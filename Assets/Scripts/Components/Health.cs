using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Components
{
    public class Health : MonoBehaviour
    {
        [field: SerializeField] public float MaxHealth { get; private set; } = 100;

        private float _value;
        public float Value
        {
            get => _value;
            set
            {
                if (value >= MaxHealth)
                {
                    _value = MaxHealth;
                }
                else
                {
                    _value = value;
                }

                OnValueChanged?.Invoke(_value);

                if (value <= 0)
                {
                    _value = 0;
                    OnHealthDepleted?.Invoke();
                }
            }
        }

        public event Action<float> OnValueChanged;
        public event Action OnHealthDepleted;

        public void ResetHealth()
        {
            Value = MaxHealth;
        }
    }

}