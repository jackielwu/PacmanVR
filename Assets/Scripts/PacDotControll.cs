using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacDotControll : MonoBehaviour {

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
            GameObject.FindObjectOfType<GameController>()._score += 10;
            Destroy(gameObject);
        }
    }
}
