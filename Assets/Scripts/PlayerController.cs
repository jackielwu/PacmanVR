using UnityEngine;




public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    private PlayerMotor motor;
    
 
    void Start ()
    {
        motor = GetComponent<PlayerMotor>();
        
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 mx = transform.right * x;
        Vector3 mz = transform.forward * z;

        Vector3 _velo = (mx + mz).normalized * speed;

        motor.Move(_velo);


    }
}
