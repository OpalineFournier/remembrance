using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource titleScreenMusic;

    // Start is called before the first frame update
    void Start()
    {
        titleScreenMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
