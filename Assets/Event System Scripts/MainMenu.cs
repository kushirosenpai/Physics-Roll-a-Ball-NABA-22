using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject DebugMenuCanvas;

    private bool menuSwitch = false;

    void Start()
    {
        DebugMenuCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuSwitch = !menuSwitch;

            if (menuSwitch)
                DebugMenuCanvas.SetActive(true);

            else DebugMenuCanvas.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
