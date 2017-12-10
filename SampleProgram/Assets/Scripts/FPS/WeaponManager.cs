// BasicFPSController
// Ryan H. Berriualt
// Handles player weapons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour 
{
	public int weaponIndex = 0;

	// Use this for initialization
	void Start () 
	{
		SelectWeapon();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// That way we dont call SelectWeapon eveyframe
		int previousSelectedWeapon = weaponIndex;

		// Scroll wheel Up
		if (Input.GetAxis("Mouse ScrollWheel") > 0f)
		{
			if(weaponIndex >= transform.childCount -1)
			{
				weaponIndex = 0;
			}
			else
			{
				weaponIndex++;
			}
		}

		// Scroll wheel down
		if (Input.GetAxis("Mouse ScrollWheel") < 0f)
		{
			if(weaponIndex >= 0)
			{
				weaponIndex = 0;
			}
			else
			{
				 weaponIndex--;
			}
		}

		// 1 keybind
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			weaponIndex = 0;
		}

		// 2 keybind
		if(Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
		{
			weaponIndex = 1;
		}

		// 3 keybind
		if(Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
		{
			weaponIndex = 2;
		}

		// 4 keybind
		if(Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4)
		{
			weaponIndex = 3;
		}

		// 5 keybind
		if(Input.GetKeyDown(KeyCode.Alpha5) && transform.childCount >= 5)
		{
			weaponIndex = 4;
		}

		// 6 keybind
		if(Input.GetKeyDown(KeyCode.Alpha6) && transform.childCount >= 6)
		{
			weaponIndex = 5;
		}

		// SelectWeapon
		if (previousSelectedWeapon != weaponIndex)
		{
			SelectWeapon();
		}
	}

	public void SelectWeapon()
	{
		int index = 0;
		foreach ( Transform weapon in transform)
		{
			if(index == weaponIndex)
			{
				weapon.gameObject.SetActive(true);
			}
			else
			{
				weapon.gameObject.SetActive(false);
			}

			index ++;
		}
	}
}
