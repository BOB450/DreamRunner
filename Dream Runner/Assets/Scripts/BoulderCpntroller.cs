using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderCpntroller : MonoBehaviour
{

    public GameObject boulder;
    public GameObject spawnP;
    public float spawnRate = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 1f, spawnRate);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawn()
    {
        Instantiate(boulder, spawnP.transform.position, Quaternion.identity);
    }
}
