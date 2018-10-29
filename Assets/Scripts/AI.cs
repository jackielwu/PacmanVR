using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public Transform[] points;
    private int des = 0;
    public Ghost ghost;

	void Start () {
        ghost.MoveToward(points[des].position);
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(ghost.transform.position, points[des].position) < 1f)
            NextPoint();

        ghost.MoveToward(points[des].position);
    }

    void NextPoint()
    {
        if (points.Length == 0)
            return;
        des = des + 1;
        if (des == points.Length)
            des = 0;
    }
}
