using System;
using UnityEngine;

public class SoupScript : MonoBehaviour
{

    private void Start()
    {

        ColorManager.SetColorRGBA(this.gameObject,1,1,1,255);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Contains("Ingredient"))
        {

            ColorManager.MixColor(this.gameObject,other.gameObject);

            ColorManager.CheckColorMatch(this.gameObject, GameObject.Find("Blaadje"));

        }

    }

}
