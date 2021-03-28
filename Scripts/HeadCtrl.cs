using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadCtrl : MonoBehaviour
{
    public Image cursorGauge; // cursorGauge 이미지 선언
    public GameObject mainCam; // mainCam 게임오브젝트 선언
    private float GaugeTimer = 0.0f; // GaugeTimer 0.0f로 초기화
    private float gazeTimer = 2.0f; // gazeTimer 2.0f로 초기화

    void Start()
    {
        Time.timeScale = 1; // 일시정지 해제
    }

    void Update()
    {
        RaycastHit hit; // RaycastHit 선언
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 1000;
        cursorGauge.fillAmount = GaugeTimer; // GaugeTimer 값에 따라 cursorGauge를 채움

        if (Physics.Raycast(this.transform.position, forward, out hit)) // 1000 크기만큼 발사
        {
            GaugeTimer += 1.0f / gazeTimer * Time.deltaTime; // 1초에 gazeTimer 만큼 값을 증가 시킴

            if (GaugeTimer >= 1.0f) // GaugeTime가 1.0f이거나 클 때
            {
                hit.transform.GetComponent<Button>().onClick.Invoke(); // Button 이벤트를 실행

                GaugeTimer = 0.0f; // GaugeTimer을 0.0f로 초기화
            }
        }

        else
            GaugeTimer = 0.0f;
    }
}

