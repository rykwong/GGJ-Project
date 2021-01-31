using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
    	StartCoroutine(ButtonDelay());
    }
    IEnumerator ButtonDelay()
	{
   		Debug.Log(Time.time);
	   	yield return new WaitForSeconds(0.45f);
    	Debug.Log(Time.time);

    	// This line will be executed after 10 seconds passed
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
    public void QuitGame()
    {
    	Debug.Log("QUIT!");
    	Application.Quit();
    }
}
