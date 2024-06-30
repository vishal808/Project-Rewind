using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect : MonoBehaviour
{
	public GameObject part;
	public Bridge bg;
   void OnTriggerEnter(Collider other)
   {
	   if(other.gameObject.tag == "Fire")
	   {
		   part.GetComponent<BoxCollider>().enabled = false;
		   bg.turnoff();
		   GetComponent<Connect>().enabled = false;
		   Debug.Log("Hit");
	   }
   }
}
