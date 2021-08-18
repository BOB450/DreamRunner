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
}
