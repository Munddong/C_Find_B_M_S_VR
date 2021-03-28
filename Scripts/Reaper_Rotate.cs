using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaper_Rotate : MonoBehaviour // 플레이어를 바라보며 게임오브젝트가 회전
{
    public Transform head;
    public GameObject reaper;
    public GameObject sp;

    // Start is called before the first frame update
    void Start()
    {
        sp.gameObject.transform.Rotate(90f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        sp.transform.LookAt(head); 
    }
}
