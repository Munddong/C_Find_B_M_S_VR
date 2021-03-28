using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_Ctrl_clock : MonoBehaviour // 부적씬 시간초 계산 
{
    Text txt;
    private UIHP uh;
    public float clock_left;

    // Start is called before the first frame update
    void Start()
    {
        uh = GameObject.Find("Head").GetComponent<UIHP>();
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        clock_left = 30 - uh.clock;
        txt.text = "Time Left: " + clock_left.ToString("N0");
    }
}