using UnityEngine;
using UnityEngine.SceneManagement;
public class MainmenuHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Update is called once per frame
    public void Option () {
        // SceneManager
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
