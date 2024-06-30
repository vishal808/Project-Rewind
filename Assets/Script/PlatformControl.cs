using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{
   public float initial;
   public float final;
   public float delay;
   bool isliftup = false;
   bool isliftdown=false;
  public void liftup()
  {
	  for(int i=0;transform.position.y<=final;i++)
	   {
		 //  transform.position = new Vector3(transform.position.x,transform.position.y+(1/delay)*Time.deltaTime,transform.position.z);
	   }
  }
  IEnumerator StartLiftUp()
  {
	   yield return new WaitForSeconds(delay);
	   
  }
  public void liftDown()
  {
	   for(int i=0;transform.position.y>=initial;i++)
	   {
		 //  transform.position = new Vector3(transform.position.x,transform.position.y-(1/delay)*Time.deltaTime,transform.position.z);
	   }
  }
}
