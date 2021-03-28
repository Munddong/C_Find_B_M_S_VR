using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moveCtrl : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject Head;
    public GameObject mainMenu;
    public GameObject Exit_button;
    public Image cursorGauge;
    private Vector3 initPlayerPosition;
    private float GaugeTimer = 0.0f;
    private bool isMouseHold = false;
    private float positionX = 0.0f;
    private float floor_positionY = 0.0f;
    private float positionY = 0.0f;
    private float positionZ = 0.0f;
    private bool isFired = false;
    private float zeroSpeed = 0.1f;
    private float maxGauge = 5.0f;
    private bool isFly = false;

    // Start is called before the first frame update
    void Start()
    {
        initPlayerPosition = Head.transform.position;
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
            if (isFly == false)
            {
                transform.Translate(mainCam.transform.TransformDirection(Vector3.forward) * 8.0f * Time.deltaTime);

                positionY = this.transform.position.y;

                if (positionY >=  floor_positionY + 4.5f)
                    positionY = floor_positionY + 4.5f;
                this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

                if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        hit.transform.GetComponent<Button>().onClick.Invoke();
                        GaugeTimer = 0.0f;
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            isMouseHold = true;

            if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    GaugeTimer = 0.0f;
                }
            }

            positionY = this.transform.position.y;

            if (positionY >= 50f)
                positionY = 50f;
            this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);
        }

        if (isMouseHold)
        {
            GaugeTimer += 3.0f * Time.deltaTime;
            if (GaugeTimer >= maxGauge)
            {
                isMouseHold = false;
                GaugeTimer = 0.0f;
            }
            if (Input.GetMouseButtonUp(1))
                Fire();
            
        }
        cursorGauge.fillAmount = GaugeTimer / maxGauge;

        positionY = this.transform.position.y;

        if (positionY >= 50f)
            positionY = 50f;
        this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

        if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
        {
            if (Input.GetMouseButtonDown(0))
            {
                hit.transform.GetComponent<Button>().onClick.Invoke();
                GaugeTimer = 0.0f;
            }
        }
    }

    IEnumerator TurnOnFire()
    {
        positionY = this.transform.position.y;

        if (positionY >= 50f)
            positionY = 50f;
        this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

        yield return new WaitForSeconds(0.5f);
        isFired = true;
        isFly = true;

        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 1000;

        if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
        {
            if (Input.GetMouseButtonDown(0))
            {
                hit.transform.GetComponent<Button>().onClick.Invoke();
                GaugeTimer = 0.0f;
            }
        }
    }

    void Fire()
    {
        positionY = this.transform.position.y;

        if (positionY >= 50f)
            positionY = 50f;
        this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

        Head.gameObject.GetComponent<Rigidbody>().AddForce(mainCam.transform.TransformDirection(Vector3.forward) * GaugeTimer * 200.0f);

        isMouseHold = false;

        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 1000;

        if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
        {
            if (Input.GetMouseButtonDown(0))
            {
                hit.transform.GetComponent<Button>().onClick.Invoke();
                GaugeTimer = 0.0f;
            }
        }

        GaugeTimer = 0.0f;
        
        StartCoroutine(TurnOnFire());
    }

    void OnCollisionEnter(Collision collision)
    {
        if (GameObject.FindGameObjectWithTag("floor"))
        {
            floor_positionY = collision.transform.position.y;
            Debug.Log(collision);
            isFly = false;
        }
    }
}