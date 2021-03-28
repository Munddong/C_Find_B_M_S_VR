using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hint2ButtonClickEvent : MonoBehaviour
{
    public Button GO;

    public void Go()
    {
        SceneManager.LoadScene("Maze3(Remember)");
    }
}
