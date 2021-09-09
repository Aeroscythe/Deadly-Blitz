using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform firepoint;

    public GameObject bullet;

    float frame = 0;

    public float framerate = 75;

    public Joystick joystick;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (joystick.Horizontal >= .1f || joystick.Horizontal <= -.1f || joystick.Vertical >= .1f || joystick.Vertical <= -.1f)
        {
            if(frame == 0){
                Shoot();
            }
            frame = (frame + 1)%framerate;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
