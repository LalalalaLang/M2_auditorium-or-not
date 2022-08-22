using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] audioSources;


    // Start is called before the first frame update
    void Start()
    {
        foreach (AudioSource source in audioSources)
        {
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
