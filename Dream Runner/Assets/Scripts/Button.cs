using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }





    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Shop()
    {
        SceneManager.LoadScene(4);
    }


    public void WipeSave()
    {
        PlayerPrefs.DeleteAll();
    }



    public void Restart2()
    {
        SceneManager.LoadScene(5);
    }

}
