using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillSoup : MonoBehaviour
{
    public Transform waterRotation;

    public void Update()
    {
        if (waterRotation.rotation.x > 0.2f || waterRotation.rotation.x < -0.2f || 
            waterRotation.rotation.z > 0.2f || waterRotation.rotation.z < -0.2f) {
            waterRotation.gameObject.GetComponent<SoupFill>().fillAmount += 0.01f;
        }
    }

    //waterRotation.rotation.x >= 0.3f || waterRotation.rotation.x <= -0.3f ||
    //waterRotation.rotation.z >= 0.3f || waterRotation.rotation.z <= -0.3f
}
