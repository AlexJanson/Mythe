using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSoupColor : ColorManager
{

    private void Start()
    {

        SetColorRGBA(this.gameObject,1f,1f,1f,1f);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Contains("Ingredient"))
        {

            MixColor(other.gameObject,this.gameObject);

        }

    }
}
