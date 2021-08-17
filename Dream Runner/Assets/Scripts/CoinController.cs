using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public Text txt;
    public int coins;
    
    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt("NumCoins");
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = coins.ToString();
        //---------------------------------------------------------------------------------------------------------------------
        //check if coin is picked up
        if (PlayerPrefs.GetInt("coin") == 1)
        {
            GameObject go = GameObject.Find("coin");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }

        if (PlayerPrefs.GetInt("coin (1)") == 1)
        {
            GameObject go = GameObject.Find("coin (1)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }

        if (PlayerPrefs.GetInt("coin (2)") == 1)
        {
            GameObject go = GameObject.Find("coin (2)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
    }
    

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "coin")
        {

            
            coins = coins + 1;
            PlayerPrefs.SetInt("NumCoins", coins);
           // Debug.Log(coins);
            Destroy(collision.gameObject);
            Debug.Log(collision.gameObject.name);

            //--------------------------------------------------------------------------------------------------------------------
            if (collision.gameObject.name == "coin")
            {
                PlayerPrefs.SetInt("coin", 1);
                Debug.Log("yay");
            }

            if (collision.gameObject.name == "coin (1)")
            {
                PlayerPrefs.SetInt("coin (1)", 1);
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (2)")
            {
                PlayerPrefs.SetInt("coin (2)", 1);
                Debug.Log("yay1");
            }
            //--------------------------------------------------------------------------------------------------------------------

            //gameObject.GetComponent<Renderer>().enabled = false;
            //gameObject.GetComponent<CircleCollider2D>().enabled = false;
            //gameObject.transform.localScale = new Vector3(0, 0, 0);
            //gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
