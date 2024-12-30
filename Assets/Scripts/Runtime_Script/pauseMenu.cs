using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject PauseMenuUI; // Renamed for clarity
    private static bool isPaused;

    void Start()
    {
        isPaused = false;
        PauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f; // Freezes the game
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f; // Resumes the game
    }
}
