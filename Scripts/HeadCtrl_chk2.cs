using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCtrl_chk2 : MonoBehaviour
{
    private float clock = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        clock += Time.deltaTime;

        if (clock >= 3.0f)
        {
            SceneManager.LoadScene("Maze2");
        }
    }
}