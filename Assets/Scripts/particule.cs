using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particule : MonoBehaviour
{

    public GameObject partic; //needed rigidbody attached with a collider
    public Vector3 vel; //random velocity
    public float switchDirection = 3;
    public float curTime = 0;

    public int radius = 5;

    //need useGravity false and isKinematic false on the rigidbody and set freezeRotation to true. 



    // Start is called before the first frame update
    void Start()
    {
        SetVel();

    }

    void SetVel()
    {
        if (Random.value > .5)
        {
            vel.x = 10 * 10 * Random.value;
        }
        else
        {
            vel.x = -10 * 10 * Random.value;
        }
        if (Random.value > .5)
        {
            vel.z = 10 * 10 * Random.value;
        }
        else
        {
            vel.z = -10 * 10 * Random.value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(partic, Random.insideUnitCircle * radius, transform.rotation);
        Destroy(partic, 3f);

        if (curTime < switchDirection)
        {
            curTime += 1 * Time.deltaTime;
        }
        else
        {
            SetVel();
            if (Random.value > .5)
            {
                switchDirection += Random.value;
            }
            else
            {
                switchDirection -= Random.value;
            }
        if (switchDirection < 1)
            {
                switchDirection = 1 + Random.value;
            }
                curTime = 0;
            }

        }
}
    /*void FixedUpdate()
    {
        partic.rigidbody.velocity = vel;

    }*/