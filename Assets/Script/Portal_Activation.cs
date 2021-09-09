using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portal_Activation : MonoBehaviour
{
    public GameObject toEnable;
    public GameObject deleteObj;

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
            Destroy(deleteObj);
            toEnable.SetActive(true);
        }
    }
}
