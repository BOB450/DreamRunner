using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shop : MonoBehaviour
{

    public Text txt1;
    int cointext;
    // Start is called before the first frame update
    void Start()
    {
        
        
        cointext = PlayerPrefs.GetInt("NumCoins");
        txt1.text = cointext.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        cointext = PlayerPrefs.GetInt("NumCoins");
        txt1.text = cointext.ToString();
    }

    public void Back()
    {
        SceneManager.LoadScene(3);
    }

    public void Speed1()
    {
        Debug.Log("pressed");
        if (PlayerPrefs.GetInt("speed1") == 0)
        {

            if (cointext >= 1)
            {
                cointext = cointext - 1;
                PlayerPrefs.SetInt("NumCoins", cointext);
                PlayerPrefs.SetInt("speed1", 1);
                Debug.Log("speed1");
            }
        }
    }

    public void Jump1()
    {
        Debug.Log("pressed");
        if (PlayerPrefs.GetInt("jump1") == 0)
        {

            if (cointext >= 2)
            {
                cointext = cointext - 2;
                PlayerPrefs.SetInt("NumCoins", cointext);
                PlayerPrefs.SetInt("jump1", 1);
                Debug.Log("jump1");
            }
        }
    }

}
