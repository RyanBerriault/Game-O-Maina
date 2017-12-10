using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPointPatrol : MonoBehaviour {

    // Var
    public float speed;
    public GameObject start_patrol_point;
    public GameObject end_patrol_point;
    private GameObject current_point;

    // On Start
    void Start()
    {
		if(speed == 0){speed = 0.1f;}
        current_point = start_patrol_point; // Init with at start
    }

    // Update is called once per frame
    void Update ()
    {
		// Walk towards current point 
		transform.position = Vector3.MoveTowards(transform.position, current_point.transform.position , speed);

		// Once at current point change current point to next
		if (this.transform.position == current_point.transform.position)
		{
			if(current_point == start_patrol_point) { current_point = end_patrol_point; }
			else if (current_point == end_patrol_point) { current_point = start_patrol_point; }
			//else { current_point = null; Debug.Log("ERROR: Patrol Null");}
		}   
    }
}
