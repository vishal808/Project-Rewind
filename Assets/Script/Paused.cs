using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Paused : MonoBehaviour
{
   public GameObject cross;
   public GameObject Pause;

	bool ispaused= false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
		{
			if(!ispaused)
			{
				Cursor.lockState = CursorLockMode.None;
				Time.timeScale = 0f;
				cross.SetActive(false);
				Pause.SetActive(true);
				ispaused = true;

			}
			else
			{
			  Cursor.lockState = CursorLockMode.Locked;
				Time.timeScale = 1f;
				cross.SetActive(true);
				Pause.SetActive(false);
					ispaused = false;

			}
		}
    }
 public	void Restart()
	{
		Debug.Log("Click");
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
 public void Menu()
 {
	 Time.timeScale = 1f;
	Cursor.lockState = CursorLockMode.None;
	 SceneManager.LoadScene(0);
 }
 public void Quit()
 {
	         Application.Quit();
 }
  public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 
}
