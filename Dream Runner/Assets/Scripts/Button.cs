using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public GameObject star1;
    public GameObject star2;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("chapter1") == 1)
        {
            star1.SetActive(true);
        }

        if (PlayerPrefs.GetInt("chapter2") == 1)
        {
            star2.SetActive(true);
        }
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


    public void menu()
    {
        SceneManager.LoadScene(0);
    }


    public void exit()
    {
        Application.Quit();
    }
}
