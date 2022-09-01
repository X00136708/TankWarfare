using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void WeaponryBTN()
    {//loads scene with a list of the different weapon avalible 
        //SceneManager.LoadScene("Insert scene name here");
    }
    public void Help()
    {//loads a screen with a guid on how to play the game
        //SceneManager.LoadScene("Insert scene name here");
    }
    public void Settings()
    {//loads a small menu with sliders to adjust volume etc.
        //SceneManager.LoadScene("Insert scene name here");
    }
}