using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public Text txt;
    int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = coins.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "coin")
        {

            
            coins = coins + 1;
            Debug.Log(coins);
            Destroy(collision.gameObject);
            //gameObject.GetComponent<Renderer>().enabled = false;
            //gameObject.GetComponent<CircleCollider2D>().enabled = false;
            //gameObject.transform.localScale = new Vector3(0, 0, 0);
            //gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
