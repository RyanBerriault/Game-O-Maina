// BasicFPSController
// Ryan H. Berriualt
// Just Basic Unsmoothed WASD Movement.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFPSController : MonoBehaviour 
{
	// Varribles
	public GameObject Cam;

	// Update is called once per frame
	void Update () 
	{
		// WASD Movement ( Make sure to set Horizontal & Vertical in Unity)
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

		// Mouse controlling the camera


	}
}
