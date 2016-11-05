using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniGameScript : MonoBehaviour {
    
    // Use this for initialization
    void Start () {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
