using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button0 : MonoBehaviour
{
    public Image cursorGauge;
    public GameObject mainCam;
    private float GaugeTimer = 0.0f;
    private float gazeTimer = 1.0f;
    public Text TextUI;
    public static string text = null;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("num"));
        Debug.Log( PlayerPrefs.GetInt("num1"));
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 1000;
        cursorGauge.fillAmount = GaugeTimer;

        if (Physics.Raycast(mainCam.transform.position, forward, out hit))
        {
            GaugeTimer += 1.0f / gazeTimer * Time.deltaTime;

            if (GaugeTimer >= 1.0f)
            {
                if (hit.collider.GetComponent<ObjectText>().text == "")
                    text = null;

                else if (hit.collider.GetComponent<ObjectText>().text == "D") // ray가 D버튼의 닿았을 때 띄워진 텍스에서 뒤에서부터 하나씩 삭제
                    text = text.Substring(0, text.Length - 1); 

                else
                    text += hit.collider.GetComponent<ObjectText>().text;
                    TextUI.text = text;

                GaugeTimer = 0.0f;

                if (text.Length == 8) // 텍스트의 길이가 8자리일 때
                {
                    if (text == PlayerPrefs.GetInt("num") + "43" + PlayerPrefs.GetInt("num1") + "1225") // text가 저장한 num + 43 + num1 +1225
                    {
                        TextUI.text = "성공"; // 위의 if문을 충족 했을 때

                        SceneManager.LoadScene("Last"); // Last를 불러옴
                    }

                    else // 위의 if문을 충족 못 했을 때
                        TextUI.text = "실패"; 
                }

                if (text.Length > 8) // 텍스트의 길이가 8자리가 넘어 갈 때
                    TextUI.text = "실패";

            }
        }

        else
            GaugeTimer = 0.0f;
     }
}
