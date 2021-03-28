using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_spawn_normal : MonoBehaviour
{
    public GameObject[] maps;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("mapmode") == 4)
            maps[0].gameObject.SetActive(true);
        else if (PlayerPrefs.GetInt("mapmode") == 5)
            maps[1].gameObject.SetActive(true);
        else if (PlayerPrefs.GetInt("mapmode") == 6)
            maps[2].gameObject.SetActive(true);

        PlayerPrefs.SetInt("mapmode", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
