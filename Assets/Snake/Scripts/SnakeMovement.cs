using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    //Transform Snake;
    Rigidbody _rigidbody;   
    public float Sensitivity;
    public Vector3 Velocity;
    private Vector3 _previousMousePosition;

    void Start()
    {        
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    public void SnakeStop()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(0, 0, -10);
    }
    

    void FixedUpdate()
    {
        _rigidbody.AddForce(Velocity, ForceMode.VelocityChange);

        // Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //_rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * Sensitivity);

        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;            
            //Snake.Translate(delta.x * Sensitivity, 0, 0);
            _rigidbody.MovePosition(transform.position + delta * Sensitivity);
        }
        _previousMousePosition = Input.mousePosition;
    }
    //private void Update()
    //{
      //  _rigidbody.AddForce(Velocity, ForceMode.VelocityChange);
    //}
}
