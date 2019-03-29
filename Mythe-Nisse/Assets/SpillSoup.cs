using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillSoup : MonoBehaviour
{
    public Transform waterRotation;

    public void Update()
    {
        if(waterRotation.rotation.x >= 30 || waterRotation.rotation.x <= -30 ||
            waterRotation.rotation.z >= 30 || waterRotation.rotation.z <= 30) {
            waterRotation.gameObject.GetComponent<SoupFill>().fillAmount += 0.01f;
        }
    }
}
