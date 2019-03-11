using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{   


    public void SetColorRGBA(GameObject prefab, float r, float g, float b, float a)
    {

        prefab.GetComponent<Renderer>().material.color = new Color(r, g, b, a);

    }


    public void MixColor(GameObject other,GameObject Object)
    {

        var otherColor = other.GetComponent<Renderer>().material.color;
        var ObjectColor = Object.GetComponent<Renderer>().material.color;

        var ObjectRender = Object.GetComponent<Renderer>();

        float newR = (otherColor.r + ObjectColor.r) / (2f);
        float newG = (otherColor.g + ObjectColor.g) / (2f);
        float newB = (otherColor.b + ObjectColor.b) / (2f);

        ObjectRender.material.color = new Color(newR, newG, newB, 1f);

    }


}
