using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent onGameStart, onGameEnd;
    void Start()
    {
        StartGame();
    }
    public void StartGame()
    {
        onGameStart?.Invoke();
    }
    public void EndGame()
    {
        onGameEnd?.Invoke();
    }
}
