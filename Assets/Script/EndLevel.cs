using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
	public GameObject Button;
	void OnTriggerEnter(Collider other)
	{//Button.transform.GetComponent<BoxCollider>().isTrigger = false;
	if(other.gameObject.tag == "Player")
	   NexLevel();
	}
	 public void NexLevel()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadAsynchronously(SceneManager.GetActiveScene().buildIndex + 1));
    }
	
   IEnumerator LoadAsynchronously(int sceneIndex)
    {
      Debug.Log("NexLevel");
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while(!operation.isDone)
        {
            float progess = Mathf.Clamp01(operation.progress / .9f);
           
            yield return null;
        }
    }
}
