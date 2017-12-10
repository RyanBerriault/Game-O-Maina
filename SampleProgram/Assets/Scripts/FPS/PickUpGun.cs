// BasicFPSController
// Ryan H. Berriualt
// pic up: delete pick up then put it in the player hand

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour 
{
	public GameObject playerHand;
	public GameObject AWP;
	public GameObject M4;
	public GameObject AK47;
	public GameObject Shotgun;
	public GameObject Pistol;

	private bool noAWP = true;
	private bool noM4 = true;
	private bool noAK47 = true;
	private bool noShotgun = true;
	private bool noPistol = true;

	void OnCollisionEnter(Collision col)
	{
		// Put AWP in playerHand
		if(col.gameObject.tag == "AWP" && noAWP)
		{
			noAWP = false;

			GameObject one = Instantiate(AWP, playerHand.transform.position, playerHand.transform.rotation);
			one.transform.parent = playerHand.transform;
			Destroy(col.gameObject);
			playerHand.GetComponent<WeaponManager>().SelectWeapon();
		}

		// Put M4 in playerHand
		if(col.gameObject.tag == "M4" && noM4)
		{
			noM4 = false;
			GameObject one = Instantiate(M4, playerHand.transform.position, playerHand.transform.rotation);
			one.transform.parent = playerHand.transform;
			Destroy(col.gameObject);
			playerHand.GetComponent<WeaponManager>().SelectWeapon();
		}

		// Put AK47 in playerHand
		if(col.gameObject.tag == "AK47" && noAK47)
		{
			noAK47 = false;
			GameObject one = Instantiate(AK47, playerHand.transform.position, playerHand.transform.rotation);
			one.transform.parent = playerHand.transform;
			Destroy(col.gameObject);
			playerHand.GetComponent<WeaponManager>().SelectWeapon();
		}

		// Put Shotgun in playerHand
		if(col.gameObject.tag == "Shotgun" && noShotgun)
		{
			noShotgun = false;
			GameObject one = Instantiate(Shotgun, playerHand.transform.position, playerHand.transform.rotation);
			one.transform.parent = playerHand.transform;
			Destroy(col.gameObject);
			playerHand.GetComponent<WeaponManager>().SelectWeapon();
		}

		// Put Pistol in playerHand
		if(col.gameObject.tag == "Pistol" && noPistol)
		{
			noPistol = false;
			GameObject one = Instantiate(Pistol, playerHand.transform.position, playerHand.transform.rotation);
			one.transform.parent = playerHand.transform;
			Destroy(col.gameObject);
			playerHand.GetComponent<WeaponManager>().SelectWeapon();
		}
	}
}
