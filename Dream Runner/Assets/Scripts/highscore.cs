using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highscore : MonoBehaviour
{

    public Text scoretxt;
     int score;
    // Start is called before the first frame update
    void Start()
    {
         score = PlayerPrefs.GetInt("time");


        string stringmy = score.ToString();


        scoretxt.text = stringmy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
