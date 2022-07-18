using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject scoreCount;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        scoreCount.SetActive(false);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false); 
        scoreCount.SetActive(true);
        Time.timeScale = 1f;
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
