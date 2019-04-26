using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTap : MonoBehaviour
{
    public float fillAmount = 1;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Pan") {
            SoupFill sf = other.GetComponentInChildren<SoupFill>();
            sf.fillAmount -= fillAmount / 1000;
        }
    }
}
