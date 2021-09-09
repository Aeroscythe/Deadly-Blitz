using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_topDown : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {

        if(joystick.Horizontal >= .1f)
        {
            movement.x = moveSpeed;
        }
        else if(joystick.Horizontal <= -.1f)
        {
            movement.x = -moveSpeed;
        }
        else
        {
            movement.x = 0f;
        }

        if (joystick.Vertical >= .1f)
        {
            movement.y = moveSpeed;
        }
        else if (joystick.Vertical <= -.1f)
        {
            movement.y = -moveSpeed;
        }
        else
        {
            movement.y = 0f;
        }

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
