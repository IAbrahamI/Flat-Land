using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void OpenLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
