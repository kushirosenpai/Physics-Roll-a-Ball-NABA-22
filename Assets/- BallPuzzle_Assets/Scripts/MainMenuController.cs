using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public GameObject DebugMenuCanvas;

    public KeyCode MainMenuKey;

    private bool menuSwitch = false;

    public AudioListener AudioListener;

    public Condition_Timer Timer;

    private float minutes, seconds;

    public TMP_Text WinScreenTimerText;

    void Start()
    {
        DebugMenuCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(MainMenuKey))
        {
            menuSwitch = !menuSwitch;

            if (menuSwitch)
            {
                DebugMenuCanvas.SetActive(true);
                PauseGame();
            }

            else { 
                DebugMenuCanvas.SetActive(false);
                UnPauseGame();
            }
        }

    }

    public void Restart()
    {
        UnPauseGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
    }

    public void UnPauseGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }

    public void WinTimerText()
    {

        minutes = Mathf.FloorToInt(Timer._time / 60);
        seconds = Mathf.FloorToInt(Timer._time % 60);

        WinScreenTimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

}
