using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
	public GameObject Bullet;
	public float bulletForce;
    private Camera mainCam;
	public Transform points1;
	public AudioSource fire;
	public float fireRate = 5f;
	float nexttime;
    // Start is called before the first frame update
    void Start()
    {
		        mainCam = Camera.main;
        
    }

	void OnMouseDown()
	{
		Shoot();
	}
	void Update()
	{
	if(Input.GetMouseButtonDown(0))
	{
		Shoot();
	}
	}
	void Shoot()
	{
		

				fire.Play();
					var bullet1 =Instantiate (
				Bullet,
					points1.position,
					points1.rotation);

				//Add velocity to the bullet
				bullet1.transform.GetComponent<Rigidbody>().velocity = 
					bullet1.transform.forward * bulletForce;	
				Destroy(bullet1,5f);
	}
}
