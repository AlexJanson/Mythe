using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTap : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Pan") {
            SoupFill sf = other.GetComponentInChildren<SoupFill>();
            sf.fillAmount -= 0.001f;
        }
    }
}
