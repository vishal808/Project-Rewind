using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlPanel : MonoBehaviour
{
   
	public GameObject Controlp;
	public GameObject Loadgame;
	bool isOn = false;
	bool isOnLoad = false;
    // Update is called once per frame
    void Start()
    {
     		Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
    }
	public void Control()
	{
		if(!isOn)
		{
			Controlp.SetActive(true);
			isOn = true;
		}
		else
		{
		Controlp.SetActive(false);
			isOn = false;
		}
	}
	public void GameLoad(){
		if(!isOnLoad)
		{
			Loadgame.SetActive(true);
			isOnLoad = true;
		}
		else
		{
		Loadgame.SetActive(false);
			isOnLoad = false;
		}
	}
	public void Level1()
	{
			 SceneManager.LoadScene(1);
	}	
	public void Level2()
	{
			 SceneManager.LoadScene(2);
	}	
	public void Level3()
	{
			 SceneManager.LoadScene(3);
	}	
	public void Level4()
	{
			 SceneManager.LoadScene(4);
	}	
	public void Level5()
	{
			 SceneManager.LoadScene(5);
	}	
	public void Level6()
	{
			 SceneManager.LoadScene(6);
	}	
	public void Level7()
	{
			 SceneManager.LoadScene(7);
	}	
	public void Level8()
	{
			 SceneManager.LoadScene(8);
	}		

	public void Level9()
	{
			 SceneManager.LoadScene(9);
	}	
}
