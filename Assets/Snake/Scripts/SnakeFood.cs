using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeFood : MonoBehaviour
{
    public GameObject sphereOriginal;
    public GameObject Player;
    //public void OnCollisionEnter(Collision col)
    //{
    //if (col.transform.tag == "Player")
    //{
    //  transform.parent = col.transform;
    //}
    //}
    private void OnTriggerEnter(Collider other)
    {
       // GameObject SphereClone = Instantiate(sphereOriginal);
        //SphereClone.transform.parent = sphereOriginal.transform.parent;
        //SphereClone.transform.position = new Vector3(sphereOriginal.transform.position.x, sphereOriginal.transform.position.y, sphereOriginal.transform.position.z - 1);
        //Instantiate(other.gameObject);
        CreateTail(1);
        Destroy(this.gameObject);
    }

    
    

    void Start()
    {
        //CreateTail(1);
    }

    private void CreateTail(int tailNum)
    {
        for (int i = 0; i < tailNum; i++)
        {                       
            GameObject SphereClone = Instantiate(sphereOriginal, new Vector3(sphereOriginal.transform.position.x, sphereOriginal.transform.position.y, sphereOriginal.transform.position.z + (tailNum * 0.5f)), sphereOriginal.transform.rotation);
            SphereClone.transform.localScale = Player.transform.localScale;
            SphereClone.name = "TailClone-" + (i + 1);
            SphereClone.transform.parent = Player.transform;            
            
        }
    }
}
