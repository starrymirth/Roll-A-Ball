using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniGameScript : MonoBehaviour
{
    private bool isPaused;
    public GameObject PauseMenuCanvas;

    void Start()
    {
        isPaused = !(Time.timeScale == 1);
        PauseMenuCanvas.SetActive(isPaused);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        PauseMenuCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        PauseMenuCanvas.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }
    
    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
