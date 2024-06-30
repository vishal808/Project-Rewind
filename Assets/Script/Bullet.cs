using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   void OnCollisionEnter(Collision co)
   {
	   Destroy(this.gameObject,0.1f);
   }
}
