using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanMap1Num : MonoBehaviour // 비밀번호 num값(0 ~ 9) 저장
{
    public GameObject[] Numbers;
    private int random_numbers;

    // Start is called before the first frame update
    void Start()
    {
        random_numbers = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (random_numbers == 0)
        {
            Numbers[0].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 0);
        }

        else if (random_numbers == 1)
        {
            Numbers[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 1);
        }

        else if (random_numbers == 2)
        {
            Numbers[2].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 2);
        }

        else if (random_numbers == 3)
        {
            Numbers[3].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 3);
        }

        else if (random_numbers == 4)
        {
            Numbers[4].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 4);
        }

        else if (random_numbers == 5)
        {
            Numbers[5].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 5);
        }

        else if (random_numbers == 6)
        {
            Numbers[6].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 6);
        }

        else if (random_numbers == 7)
        {
            Numbers[7].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 7);
        }

        else if (random_numbers == 8)
        {
            Numbers[8].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 8);
        }

        else if (random_numbers == 9)
        {
            Numbers[9].gameObject.SetActive(true);
            PlayerPrefs.SetInt("num", 9);
        }
    }
}
