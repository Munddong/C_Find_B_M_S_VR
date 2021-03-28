using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private float clock;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("stage", 0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;

        if(clock >= 5.0f)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
