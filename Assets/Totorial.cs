using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totorial : MonoBehaviour
{
   
   public GameObject pic;
	public GameObject audio;
	public float time = 2f;

	void Start()
	{
		StartCoroutine(showit());
	}
	IEnumerator showit()
	{
		yield return new WaitForSeconds(time);
		pic.SetActive(true);
		Destroy(pic,5f);
		if(audio!=null)
			audio.SetActive(true);
	}
}
