using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void BtnStart()
    {
        SceneManager.LoadScene("Scenes/lvlSideGrab");
        Time.timeScale = 1f;
    }

    public void BtnExit()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
