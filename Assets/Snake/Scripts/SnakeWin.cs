using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeWin : MonoBehaviour
{
    public GameObject gameoverUI;

    public void GameWin()
    {
        gameoverUI.SetActive(true);
    }
    public void nextlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void looplvl()
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {        
        GameWin();
    }
}
