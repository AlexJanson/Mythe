using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotitieColor : ColorManager
{
    void Start()
    {

        SetColorRGBA(this.gameObject, Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);

    }

}
