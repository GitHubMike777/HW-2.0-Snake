using UnityEngine;

public class SnakeCamFollow : MonoBehaviour
{
    public Vector3 vec;
    public Transform target;
    public GameObject target2;

    public void Update()
    {
        if (target2.gameObject != null)
        {
            transform.position = target.position + vec;
        }
    }
    public void CamFol()
    {
        
        

    }

    public void CamStop()
    {
        transform.position = (target.position + vec) * 0;
    }
}
