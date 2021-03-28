using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad_Hint2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject == GameObject.FindGameObjectWithTag("head"))
        {
            SceneManager.LoadScene("Hint2");
        }
    }
}
