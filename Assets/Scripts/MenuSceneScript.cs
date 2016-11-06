using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneScript : MonoBehaviour
{
    public void PlayLevel(int BuildIndex)
    {
        SceneManager.LoadScene(BuildIndex);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
