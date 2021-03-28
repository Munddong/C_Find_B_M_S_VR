using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseCtrl : MonoBehaviour
{
    public GameObject panel;
    private bool isPaused;

    // Use this for initialization
    void Start()
    {
        isPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2)) // 마우스 휠 버튼을 눌렀을 때 일시정지
        {
            pause();
        }
    }

    void pause()
    {
        if (isPaused) // 일시정지면 패널 활성화
        {
            Time.timeScale = 0;
            isPaused = false;
            panel.gameObject.SetActive(true);
        }

        else // 일시정지가 아니면 패널 비활성화
        {
            Time.timeScale = 1;
            isPaused = true;
            panel.gameObject.SetActive(false);
        }
    }
}
