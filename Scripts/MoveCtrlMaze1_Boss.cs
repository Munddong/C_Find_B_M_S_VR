using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveCtrlMaze1_Boss : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject Head;
    public Image cursorGauge;
    private float GaugeTimer = 0.0f;
    public GameObject mainMenu;
    public GameObject Exit_button;
    private float positionX = 0.0f;
    private float positionY = 0.0f;
    private float positionZ = 0.0f;
    public int PlayerHp = 10;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 1000;
        cursorGauge.fillAmount = GaugeTimer;

        if (Input.GetMouseButton(0))
        {
            transform.Translate(mainCam.transform.TransformDirection(Vector3.forward) * 8.0f * Time.deltaTime);

            positionX = this.transform.position.x;
            positionY = this.transform.position.y;
            positionZ = this.transform.position.z;

            if (positionX >= 24.5f)
                positionX = 24.5f;

            else if (positionX <= -24.5f)
                positionX = -24.5f;

            else if (positionY >= 4.5f)
                positionY = 4.5f;

            else if (positionZ >= 24.5f)
                positionZ = 24.5f;

            else if (positionZ <= -24.5f)
                positionZ = -24.5f;

            this.transform.position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
            {
                //GaugeTimer += 1.0f / 3.0f * Time.deltaTime;

                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    GaugeTimer = 0.0f;
                }
            }
        }
    }
}