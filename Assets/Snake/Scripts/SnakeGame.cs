using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeGame : MonoBehaviour
{
    public SnakeMovement Controls;
    public GameObject LastHP;
    public enum State
    {
        Playing,
        Win,
        Loss,
    }
    private void Update()
    {
        Die();
    }
    private void OnDisable()
    {
        if (LastHP.activeInHierarchy)
        {

        }
        else
        {
            //OnPlayerDied();
            SceneManager.LoadScene(1);
        }
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

    private void OnDestroy()
    {
        OnPlayerDied();
    }
    void Die()
    {
        
        if (LastHP.gameObject == null)
        {
            OnPlayerDied();            
        }
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
