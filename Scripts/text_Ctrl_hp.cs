using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_Ctrl_hp : MonoBehaviour // 부적씬 HP 계산 
{

    Text txt;
    private MoveCtrlMaze1_Boss mv;

    // Start is called before the first frame update
    void Start()
    {
        mv = GameObject.Find("Head").GetComponent<MoveCtrlMaze1_Boss>();
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "HP: 10/" + mv.PlayerHp.ToString("N0");
    }
}
