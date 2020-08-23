using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevelManager : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public void startLv01()
    {
        SceneManager.LoadScene("Lv01");
    }
    public void startLv02()
    {
        SceneManager.LoadScene("Lv02");
    }
    public void startLv03()
    {
        SceneManager.LoadScene("Lv03");
    }
    public void startLv04()
    {
        SceneManager.LoadScene("Lv04");
    }
    public void startLv05()
    {
        SceneManager.LoadScene("Lv05");
    }
}
