using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Player;

    Vector3 p;

    // Update is called once per frame
    void Update()
    {
        p = Player.position + new Vector3(0,0,-10);
        transform.position = p;
    }
}
