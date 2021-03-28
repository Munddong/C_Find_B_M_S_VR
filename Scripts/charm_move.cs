using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charm_move : MonoBehaviour
{
    public GameObject bullet;
    public float moveSpeed = 120.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet.transform.Translate(Vector3.forward * 10.0f * Time.deltaTime);
        Destroy(bullet.gameObject, 5.0f); // 5초 뒤에 게임오브젝트 삭제 
    }

    void OnCollisionEnter(Collision other) // head라는 태그를 찾아 충돌 했을 때 게임오브젝트 삭제
    {
        if (other.gameObject.CompareTag("head"))
        {
            Destroy(this.gameObject, 0.0f); 
        }
    }
}
