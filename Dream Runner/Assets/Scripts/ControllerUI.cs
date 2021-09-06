using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerUI : MonoBehaviour
{

    public int sence;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene(sence);
            print("joystick 1 button ");
        }

        if (Input.GetKeyDown("joystick button 1"))
        {
            SceneManager.LoadScene(5);
            print("joystick 1 button ");
        }

    }
}
