using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class meanu : MonoBehaviour
{
    public GameObject Loading;
    public Slider slide; 
  public void StartGame()
    {// UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
        StartCoroutine(LoadAsynchronously(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void quit()
    {
        Application.Quit();
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        Loading.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while(!operation.isDone)
        {
            float progess = Mathf.Clamp01(operation.progress / .9f);
            slide.value = progess;
            yield return null;
        }
    }
}
