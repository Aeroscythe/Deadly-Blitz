using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kebab_remover : MonoBehaviour
{

    public Rigidbody2D rb;

    float currentTime = 0f;
    float startTime = 2f;

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
            Destroy(this.gameObject);
        }
    }
}
