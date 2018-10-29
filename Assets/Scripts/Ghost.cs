using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Pacman")
        {
            if(!GameObject.FindObjectOfType<GameController>().energized)
            {
                Time.timeScale = 0;
                GameObject.FindObjectOfType<GameController>()._lives--;
                other.transform.position = new Vector3(-19.52f, 0.082f, -25.5f);
                Time.timeScale = 1;
            }
            else
            {
                transform.position = new Vector3(0, 0, 0);
                GameController.FindObjectOfType<GameController>()._score += 100;
            }
        }
    }

    public void MoveToward(Vector3 _point)
    {
        int speed = 5;
        _point = _point - transform.position;
        float rotationSpeed = 20f;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_point), rotationSpeed * Time.deltaTime);
        
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        _point = forward * speed;

        GetComponent<CharacterController>().Move(_point * Time.deltaTime);
    }
}
