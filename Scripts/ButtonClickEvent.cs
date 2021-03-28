using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickEvent : MonoBehaviour
{
    public Button start;
    public Button exit;

    public void St()
    {
        SceneManager.LoadScene("Maze1"); 
    }

    public void Ex()
    {
        Application.Quit();
    }
}
