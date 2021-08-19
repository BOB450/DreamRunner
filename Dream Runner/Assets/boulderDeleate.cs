using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderDeleate : MonoBehaviour
{

  
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(30f);
        Destroy(gameObject);
    }

}
