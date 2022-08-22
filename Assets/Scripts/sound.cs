using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    public AudioClip Sound;
    Transform ZoneSGameObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(Sound);
            Col.gameObject.transform.position = GameObject.Find("ZoneStart").GetComponent<Transform>().position;
            GameObject.Find("Capsule").GetComponent<Transform>().position = ZoneSGameObject.Find("ZoneStart").GetComponent<Transform>().position;


        }

    }
}
