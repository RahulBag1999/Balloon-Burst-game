using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;

    public void settings()
    {
        settingsMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void back()
    {
        settingsMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
