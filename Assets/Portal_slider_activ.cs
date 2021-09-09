using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_slider_activ : MonoBehaviour
{
    public GameObject toEnable;

    float currentTime = 0f;
    public float startTime = 120f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            toEnable.SetActive(true);
        }
    }
}
