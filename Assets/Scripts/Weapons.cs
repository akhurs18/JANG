
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {

	public Transform firePoint;
	public Rigidbody2D bulletPrefab;
	public GameObject spawnPoint;
	public float speed;
	public float fireRate = 3.0f;
	private float lastShot = 0.0f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			Shoot();
		}
	}

	void Shoot ()
	{
		if (Time.time > fireRate + lastShot)
     {
         bulletPrefab = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
         lastShot = Time.time;
     }



	}
}
