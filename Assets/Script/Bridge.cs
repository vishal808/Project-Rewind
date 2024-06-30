using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
	public	Rigidbody rb;
	bool p1=true,p2=true;
	void Start()
	{
		if(rb==null)
		rb = GetComponent<Rigidbody>();
	}
	void Update()
	{
		if(!p1&&!p2)
		{
			rb.isKinematic = false;
			p1=true;
			p2=true;
		}
		if(transform.rotation.x>80f||Input.GetKeyDown("q"))
		{
			p1=true;
			p2=true;
			rb.isKinematic = true;
			Debug.Log("isActive");
		}
	}	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Connect")
		{
				p1=true;
				p2=true;
	rb.isKinematic = true;
		Debug.Log("IsActive");}
	}
	public void turnoff()
	{
		if(p1)
		{
			p1=false;
		}
		else
			p2=false;
	}
}
