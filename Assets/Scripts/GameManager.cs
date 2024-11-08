using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent onGameStart, onGameEnd, onGamePause, onGameResume;
    bool isPaused;
    void Start()
    {
        StartGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }
    public void StartGame()
    {
        onGameStart?.Invoke();
    }
    public void EndGame()
    {
        onGameEnd?.Invoke();
    }
    public void PauseGame()
    {
        isPaused = true;
        onGamePause?.Invoke();
    }
    public void ResumeGame()
    {
        isPaused = false;
        onGameResume?.Invoke();
    }
}
