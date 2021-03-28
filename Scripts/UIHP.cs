using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHP : MonoBehaviour
{
    public Image gauge;
    public Image clock_Image;
    public float hp = 0.0f;
    public float clock = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        gauge.fillAmount = hp;
        clock_Image.fillAmount = clock / 30.0f;

        clock += 1.0f * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            
            hp += 0.1f;

            Destroy(other.gameObject, 0.0f);
        }
    }
}
