using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beam : MonoBehaviour
{
    public float rate = 4;
    public float rate2 = 4;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Change", 1f, rate);
        InvokeRepeating("Changeback", rate2, rate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Change()
    {
        GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
        this.GetComponent<BoxCollider2D>().enabled = false;
    }

    void Changeback()
    {

        this.GetComponent<BoxCollider2D>().enabled = true; //This could work for almost any component

        GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
        
    }
}
