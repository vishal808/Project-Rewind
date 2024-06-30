using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Transform origin;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag != "Fire" && other.gameObject.tag == "Cube"){
		this.transform.GetComponent<Rigidbody>().isKinematic = false;
		Debug.Log("Touch");
	
			//transform.position = origin.position;
			//this.transform.GetComponent<Rigidbody>().isKinematic = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag != "Fire" && other.gameObject.tag == "Cube"){
		//transform.position = origin.position;
			this.transform.GetComponent<Rigidbody>().isKinematic = true;
			Debug.Log("No Touch");
		}
	}
}
