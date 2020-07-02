using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource lvlMusic;
    public GameObject pauseMenu;
    public AudioSource pauseSound;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(gamePaused==false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                lvlMusic.Pause();
                pauseMenu.SetActive(true);
                pauseSound.Play();
            }
            else
            {
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
                lvlMusic.UnPause();
                pauseMenu.SetActive(false);
            }
        }
    }
    public void resumeGame()
    {
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        lvlMusic.UnPause();
        pauseMenu.SetActive(false);
    }

    public void restartGame()
    {
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        lvlMusic.UnPause();
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(2);
    }

    public void quitGame()
    {
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        lvlMusic.UnPause();
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
