using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_name : MonoBehaviour
{
    float currentTime = 0f;
    public float startTime = 6f;

    public Animator transition;
    public float transitiontime;

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
            Continuation();
        }
    }

    public void Continuation()
    {
        SceneManager.LoadScene("00. Name");
    }
}
