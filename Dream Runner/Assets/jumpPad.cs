using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{

    public GameObject player;

    Vector3 direction;

    public float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //generate vector in the direction of jump pad's y axis multiplied with a factor jumpForce

        direction = transform.TransformDirection(Vector3.up * jumpForce);
    }


void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("player")) //applies only to objects tagged with “Player”
    {
            Debug.Log("PAD");
        player = collision.gameObject;
        //apply force to the Player's rigidbody to let him "jump"
        player.GetComponent<Rigidbody2D>().AddForce(direction, ForceMode2D.Impulse);
    }
}

}
