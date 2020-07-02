using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manmenufunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redtolvl = 3;
        SceneManager.LoadScene(2);
    }
 
    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void credits()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }
}
