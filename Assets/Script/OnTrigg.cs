using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnTrigg : MonoBehaviour
{
	public GameObject audio;
	public bool isEnd=false;
  void OnTriggerEnter(Collider ot)
  {
	  if(ot.gameObject.tag == "Cube")
	  {
		  audio.SetActive(true);
		  Destroy(audio,8f);
	  }
	  else if(isEnd)
	  {  audio.SetActive(true);
    StartCoroutine(ending());
	  }
  }
  IEnumerator ending()
  {
	  yield return new WaitForSeconds(7f);
	    SceneManager.LoadScene(0);
	  
  }
}
