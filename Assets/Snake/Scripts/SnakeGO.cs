using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeGO : MonoBehaviour
{
    public GameObject gameoverUI;    

    public void GameOver()
    {        
        gameoverUI.SetActive(true);
        PlaySound();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }

    void PlaySound()
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
