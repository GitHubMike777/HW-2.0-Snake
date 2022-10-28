using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeBlocks : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //Destroy(collision.gameObject);
    //Destroy(this.gameObject);

    //}


    public SnakeGO gameManager;    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // SceneManager.LoadScene(1);         
        Destroy(other.gameObject);
        gameManager.GameOver();
        }

        Destroy(other.gameObject);
        Destroy(this.gameObject);
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
