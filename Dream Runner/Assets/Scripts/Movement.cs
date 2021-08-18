using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runspeed = 80f;
    public float horizontalMove = 0f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("speed1") == 1)
        {
            runspeed = 90f;
            Debug.Log("speed activated");
        }
        else { runspeed = 80f; }

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed ;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


}
