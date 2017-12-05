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
