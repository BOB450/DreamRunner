using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public Text txt;
    public int coins;
    public AudioManger other;
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

        if (PlayerPrefs.GetInt("coin (3)") == 1)
        {
            GameObject go = GameObject.Find("coin (3)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }

        if (PlayerPrefs.GetInt("coin (4)") == 1)
        {
            GameObject go = GameObject.Find("coin (4)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }

        if (PlayerPrefs.GetInt("coin (5)") == 1)
        {
            GameObject go = GameObject.Find("coin (5)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }

        if (PlayerPrefs.GetInt("coin (6)") == 1)
        {
            GameObject go = GameObject.Find("coin (6)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }

        if (PlayerPrefs.GetInt("coin (7)") == 1)
        {
            GameObject go = GameObject.Find("coin (7)");
            //if the coin exist then destroy it
            if (go)
            {
                Destroy(go.gameObject);
                Debug.Log(name + "has been destroyed.");
            }
        }


        if (PlayerPrefs.GetInt("coin (8)") == 1)
        {
            GameObject go = GameObject.Find("coin (8)");
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

            other.CoinSound();
            coins = coins + 1;
            PlayerPrefs.SetInt("NumCoins", coins);
           // Debug.Log(coins);
            Destroy(collision.gameObject);
            Debug.Log(collision.gameObject.name);

            //--------------------------------------------------------------------------------------------------------------------
            if (collision.gameObject.name == "coin")
            {
                PlayerPrefs.SetInt("coin", 1);
                other.CoinSound();
                Debug.Log("yay");
            }

            if (collision.gameObject.name == "coin (1)")
            {
                PlayerPrefs.SetInt("coin (1)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (2)")
            {
                PlayerPrefs.SetInt("coin (2)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (3)")
            {
                PlayerPrefs.SetInt("coin (3)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (4)")
            {
                PlayerPrefs.SetInt("coin (4)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (5)")
            {
                PlayerPrefs.SetInt("coin (5)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (6)")
            {
                PlayerPrefs.SetInt("coin (6)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (7)")
            {
                PlayerPrefs.SetInt("coin (7)", 1);
                other.CoinSound();
                Debug.Log("yay1");
            }

            if (collision.gameObject.name == "coin (8)")
            {
                PlayerPrefs.SetInt("coin (8)", 1);
                other.CoinSound();
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
