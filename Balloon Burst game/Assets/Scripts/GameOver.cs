using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject HUD_buttons;
    [SerializeField] GameObject scoreText;
    

    private void Update()
    {
        if(GameObject.FindGameObjectWithTag("Pin")==null)
        {
            gameOverPanel.SetActive(true);
            HUD_buttons.SetActive(false);
            scoreText.SetActive(false);
            
        }
    }
    public void Home(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
