using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseCtrl1 : MonoBehaviour
{
    public Button main;
    public Button Exit;

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Exit_Event()
    {
        Application.Quit();
    }
}

