using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playe_rot : MonoBehaviour
{
    public Rigidbody2D rb;
    public Joystick joystick1;

    float position;
    private void FixedUpdate()
    {
        //float position;

        Vector2 lookDir = new Vector2(joystick1.Horizontal, joystick1.Vertical);
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        if((lookDir.x != 0) || (lookDir.y != 0))
        {
            rb.rotation = angle - 90;
            position = rb.rotation;
        }
        else
        {
            rb.rotation = position;
        }
    }
}
