using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");

    }


    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void TryAgain()
    {
        SceneManager.LoadScene("Gameplay");

        Time.timeScale = 1.0f;


        
    }
   


}

