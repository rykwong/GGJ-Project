using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        	if(GameIsPaused)
        	{
        		pauseMenuUI.SetActive(false);
                GameIsPaused = false;
        	}
        	else
        	{
	        	Pause();
        	}
    	}
    }

    public void Resume()
    {
    	StartCoroutine(ResumeDelay());
    }
    IEnumerator ResumeDelay()
    {
    	yield return new WaitForSeconds(0.45f);
    	pauseMenuUI.SetActive(false);
    //	Time.timeScale = 1f;
    	GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
    //    Time.timeScale = 0f;
        GameIsPaused = true;
    	//StartCoroutine(PauseDelay());
    }
    IEnumerator PauseDelay()
    {
    	yield return new WaitForSeconds(0.45f);
    }

    public void LoadMenu()
    {
    	StartCoroutine(LoadDelay());
    }
    IEnumerator LoadDelay()
    {
    	yield return new WaitForSeconds(0.45f);
    //	Time.timeScale = 1f;
    	SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
    	StartCoroutine(QuitDelay());
    }
    IEnumerator QuitDelay()
    {
    	yield return new WaitForSeconds(0.45f);
    	Debug.Log("Quitting");
    	Application.Quit();
    }
}
