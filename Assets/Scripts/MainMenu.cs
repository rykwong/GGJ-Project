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
	   	yield return new WaitForSeconds(0.45f);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		SceneManager.LoadScene("BarkandFound");
	}
    public void QuitGame()
    {
    	Debug.Log("QUIT!");
    	Application.Quit();
    }
}
