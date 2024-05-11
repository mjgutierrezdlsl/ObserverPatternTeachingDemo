using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDisableListener : MonoBehaviour
{
    [SerializeField] private UnityEvent _onDisable;
    void OnDisable()
    {
        _onDisable?.Invoke();
    }
}
