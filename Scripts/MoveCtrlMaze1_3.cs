using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveCtrlMaze1_3 : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject Head;
    public Image cursorGauge;
    private float GaugeTimer = 0.0f;
    public GameObject mainMenu;
    public GameObject Exit_button;
    private float positionY = 0.0f;

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
            transform.Translate(mainCam.transform.TransformDirection(Vector3.forward) * 7.0f * Time.deltaTime);

            positionY = this.transform.position.y;

            if (positionY >= 4.5f)
                positionY = 4.5f;
            this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

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