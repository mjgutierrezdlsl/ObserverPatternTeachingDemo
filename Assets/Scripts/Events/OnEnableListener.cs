using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableListener : MonoBehaviour
{
    [SerializeField] private UnityEvent onEnable;
    void OnEnable()
    {
        onEnable?.Invoke();
    }
}
