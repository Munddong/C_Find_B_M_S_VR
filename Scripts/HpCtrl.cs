using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpCtrl : MonoBehaviour
{
    private MoveCtrlMaze1_Boss mv;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        mv = GameObject.FindGameObjectWithTag("head").GetComponent<MoveCtrlMaze1_Boss>(); // head라는 태그가 붙은 오브젝트의 들어있는 MoveCtrlMaze1_Boss의 스크립트를 이용할 수 있게 함
    }

    // Update is called once per frame
    void Update()
    {        
        if (mv.PlayerHp < 1)
        {
            SceneManager.LoadScene("chk1");

        }
    }

    void OnCollisionEnter(Collision other) // bullet이라는 태그를 가진 오브젝트와 충돌 시 플레이어의 HP를 1씩 감소
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            mv.PlayerHp--;

            Destroy(other.gameObject, 0.0f);
        }
        Debug.Log(mv.PlayerHp);
    }
}
