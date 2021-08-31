using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text scoretxt;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        scoretxt.text = "0";
        InvokeRepeating("addscore", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerPrefs.SetInt("time", num);
    }
    void addscore()
    {

        num++;

        string stringmy = num.ToString();


        scoretxt.text = stringmy;

        PlayerPrefs.SetInt("time", num);
    }
}