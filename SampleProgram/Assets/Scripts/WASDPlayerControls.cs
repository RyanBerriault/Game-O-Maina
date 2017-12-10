// BasicFPSController
// Ryan H. Berriualt
// Just Basic Unsmoothed WASD Movement.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDPlayerControls : MonoBehaviour {

	// Varribles
	public GameObject Cam;
	public float xSens;
	public float YSens;

	// Update is called once per frame
	void Update () 
	{
		// WASD Movement ( Make sure to set Horizontal & Vertical in Unity)
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * xSens;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * YSens;

        transform.Rotate(0, x, 0);
	}
}
