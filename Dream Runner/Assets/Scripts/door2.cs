using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door2 : MonoBehaviour
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
        Debug.Log("you won");

        if (collision.gameObject.tag == "player")
        {

            PlayerPrefs.SetInt("chapter2", 1);
            SceneManager.LoadScene(3);



        }
    }
}
