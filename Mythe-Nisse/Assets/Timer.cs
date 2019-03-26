using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float TimeLeft = 180f; // 3 minutes default

    public static Action onTimeChanged;

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if(onTimeChanged != null)
        {
            onTimeChanged();
        }
    }
}
