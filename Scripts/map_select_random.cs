using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class map_select_random : MonoBehaviour {
    public GameObject easy;
    public GameObject normal;
    public GameObject hard;
    public int ran_num;

    public void Easy() // Easy선택 시 각 할당 된 숫자의 해당하는 맵이 나옴
    {
        ran_num = Random.Range(1, 4);

        if (ran_num == 1)
            PlayerPrefs.SetInt("mapmode", 1);

        else if (ran_num == 2)
            PlayerPrefs.SetInt("mapmode", 2);

        if (ran_num == 3)
            PlayerPrefs.SetInt("mapmode", 3);

        SceneManager.LoadScene("EasyBoss2");
    }

    public void Normal() // Normal 선택 시 각 할당 된 숫자의 해당하는 맵이 나옴
    {
        ran_num = Random.Range(4, 7);

        if (ran_num == 4)
            PlayerPrefs.SetInt("mapmode", 4);

        else if (ran_num == 5)
            PlayerPrefs.SetInt("mapmode", 5);

        if (ran_num == 6)
            PlayerPrefs.SetInt("mapmode", 6);

        SceneManager.LoadScene("NormalBoss2");
    }

    public void Hard() // Hard 선택 시 각 할당 된 숫자의 해당하는 맵이 나옴
    {
        ran_num = Random.Range(7, 10);

        if (ran_num == 7)
            PlayerPrefs.SetInt("mapmode", 7);

        else if (ran_num == 8)
            PlayerPrefs.SetInt("mapmode", 8);

        if (ran_num == 9)
            PlayerPrefs.SetInt("mapmode", 9);

        SceneManager.LoadScene("HardBoss2");
    }
}
