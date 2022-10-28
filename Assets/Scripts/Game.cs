using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
   public Controls Controls;
   public enum State
    {
        Playing,
        Win,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Controls.enabled = false;
        Debug.Log("Game Over!");
        ReloadLevel();
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Win;
        Controls.enabled = false;
        Debug.Log("Victory!");
        NextLevel();
    }
    
    private void NextLevel()
    {
        SceneManager.LoadScene(1);
    }
    private void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
