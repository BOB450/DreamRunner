using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    public int speed;
    public Transform player;
    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (move == true)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            Vector3 pos = transform.position;

            // transform.position = player.position.y;
            transform.position = new Vector3(pos.x, player.position.y, 0);
        }
    }
}
