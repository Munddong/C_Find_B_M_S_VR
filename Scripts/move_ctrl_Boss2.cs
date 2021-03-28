using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move_ctrl_Boss2 : MonoBehaviour
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

        positionY = this.transform.position.y;
        if (positionY < 0.0f)
            SceneManager.LoadScene("map_select");

        if (Input.GetMouseButton(0)) // 마우스 왼쪽 버튼을 누르면
        {
            if (isFly == false) // 점프상태가 아니면 이동
            {
                transform.Translate(mainCam.transform.TransformDirection(Vector3.forward) * 8.0f * Time.deltaTime);

                positionY = this.transform.position.y;

                if (positionY >= floor_positionY + 4.5f)
                    positionY = floor_positionY + 4.5f;
                this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);

                if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
                { // ray로 메인메뉴나 종료버튼을 봤을 때 버튼 이벤트 실행
                    if (Input.GetMouseButtonDown(0)) 
                    {
                        hit.transform.GetComponent<Button>().onClick.Invoke();
                        GaugeTimer = 0.0f;
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1)) // 마우스 오른쪽 버튼을 누르고 있는 동안
        {
            isMouseHold = true; // 마우스가 눌린 지 여부 판단

            if (Physics.Raycast(this.transform.position, forward, out hit) && (hit.transform.gameObject == mainMenu || hit.transform.gameObject == Exit_button))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    GaugeTimer = 0.0f;
                }
            }
        }

        if (isMouseHold) // 마우스가 눌렸을 때
        {
            GaugeTimer += 3.0f * Time.deltaTime;

            if (GaugeTimer >= maxGauge)  // 게이지가 3초 이상이면 게이지 타이머 0으로 초기화 
            {
                isMouseHold = false;
                GaugeTimer = 0.0f;
            }

            if (Input.GetMouseButtonUp(1)) // 오른쪽 버튼을 떼면 날아감
                Fire();
        }
        cursorGauge.fillAmount = GaugeTimer / maxGauge;

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

    void Fire() // 플레이어 발사 함수
    {
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

    void OnCollisionEnter(Collision collision) // floor 태그를 가진 오브젝트에 충돌 했을 때 플레이어의 점프 상태 아님
    {
        if (GameObject.FindGameObjectWithTag("floor"))
        {
            floor_positionY = collision.transform.position.y;
            Debug.Log(collision);
            isFly = false;
        }
    }
}