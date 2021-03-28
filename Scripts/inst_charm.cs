using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class inst_charm : MonoBehaviour
{
    public float clock;
    public GameObject Head;
    public GameObject bullet;
    public Transform spawn_point;
    private MoveCtrlMaze1_Boss mv;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn()); // Spawn() 함수 실행

        mv = GameObject.FindGameObjectWithTag("head").GetComponent<MoveCtrlMaze1_Boss>();
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;

        if ((clock >= 30) && (mv.PlayerHp > 0))
        {
            SceneManager.LoadScene("Hint1");
        }
    }

    IEnumerator Spawn()
    {
        while (true) // 정해놓은 시간 초마다 게임오브젝트 생성 시간이 달라짐
        {
            if (clock >= 0 && clock <= 5)
            {
                yield return new WaitForSeconds(1.0f);

                Vector3 spawn = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                Instantiate(bullet, spawn, transform.rotation);
            }

            else if (clock > 5 && clock <= 10)
            {
                yield return new WaitForSeconds(0.8f);

                Vector3 spawn = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                Instantiate(bullet, spawn, transform.rotation);
            }

            else if (clock > 10 && clock <= 20)
            {
                yield return new WaitForSeconds(0.5f);

                Vector3 spawn = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                Instantiate(bullet, spawn, transform.rotation);
            }

            else
            {
                yield return new WaitForSeconds(1.0f);

                Vector3 spawn = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                Instantiate(bullet, spawn, transform.rotation);
            }
        }
    }
}
