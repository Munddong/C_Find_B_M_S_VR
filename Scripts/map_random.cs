using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_random : MonoBehaviour
{
    public GameObject[] mazes; // mazes 배열 선언
    private int random_num;

    // Start is called before the first frame update
    void Start()
    {
        random_num = Random.Range(0, 4); // random_num에 4개의 랜덤 생성
    }

    // Update is called once per frame
    void Update() // 랜덤에서 나온 숫자에 할당되는 맵이 활성화
    {
        if (random_num == 0) 
            mazes[0].gameObject.SetActive(true);

        else if (random_num == 1)
            mazes[1].gameObject.SetActive(true);

        else if (random_num == 2)
            mazes[2].gameObject.SetActive(true);

        else if (random_num == 3)
            mazes[3].gameObject.SetActive(true);
    }
}
