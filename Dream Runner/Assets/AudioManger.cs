using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManger : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip coin;
    public float volume = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
       // audioSource.PlayOneShot(clip, volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpSound()
    {
        audioSource.PlayOneShot(clip, volume);
    }

    public void CoinSound()
    {
        audioSource.PlayOneShot(coin, volume);
    }

}
