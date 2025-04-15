using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseUI.SetActive(isPaused);
            Time.timeScale = isPaused ? 0 : 1;
        }
    }

    public void Resume()
    {
        isPaused = false;
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
