using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class To_Portal : MonoBehaviour
{
    public Rigidbody2D player;
    public Rigidbody2D portal;
    public Slider slider;

    public float maxDist;

    void Start()
    {
        slider.maxValue = maxDist;
        slider.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, portal.transform.position);
        float Value = maxDist - distance;

        if(Value <= 0)
        {
            slider.value = 0f;
        }
        else
        {
            slider.value = Value;
        }
    }
}
