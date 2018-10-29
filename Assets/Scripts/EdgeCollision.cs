using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeCollision : MonoBehaviour {

    public GameObject edge;

    private void OnTriggerEnter(Collider other)
    {
        if (edge.name == "Edge (1)")
            other.transform.position = edge.transform.position + new Vector3(-2, 0, 0);
        if (edge.name == "Edge")
            other.transform.position = edge.transform.position + new Vector3(2, 0, 0);
    }
}
