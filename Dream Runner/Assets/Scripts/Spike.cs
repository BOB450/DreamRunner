using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       // Debug.Log("ggg");

        if (collision.gameObject.tag == "player")
        {
            SceneManager.LoadScene(2);
            Debug.Log("MyTag");
        }
    }
}
