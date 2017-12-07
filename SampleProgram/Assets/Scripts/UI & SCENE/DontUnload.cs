// BasicFPSController
// Ryan H. Berriualt
// Trasfer gameObject from scene to scene. ( For Perssistent Data )

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontUnload : MonoBehaviour 
{
	void Awake () 
	{
		DontDestroyOnLoad(this.transform.gameObject);
	}
}
