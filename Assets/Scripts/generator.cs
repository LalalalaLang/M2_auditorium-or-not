using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject particule;
    public int radius = 5;
    public float timer;
    public float timelate = 4f;

    public int counter = 0;
    public int rate = 60;


    // public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        Instantiate(particule, Random.insideUnitCircle * radius, transform.rotation);

        float timegap = timer + timelate;

        if (Time.time >= timelate)
        {
            Instantiate(particule, Random.insideUnitCircle * radius, transform.rotation);
            timer = Time.time;
        }

        counter++;


        if (counter % rate == 100)
        {

            Debug.Log("message");
        }

        Destroy(particule, 5f);
    }
}
