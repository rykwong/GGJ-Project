using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenu : MonoBehaviour
{
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
}
