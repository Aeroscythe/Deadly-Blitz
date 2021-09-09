using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Handler : MonoBehaviour
{
    public static Music_Handler Bg;

    private void Awake()
    {
        if(Bg != null && Bg != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Bg = this;
        DontDestroyOnLoad(this);
    }
}
