﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAnimation : MonoBehaviour
{
    public GameObject liquid;
    public GameObject liquidMesh;

    private int sloshSpeed = 60;
    private int rotateSpeed = 15;

    private int difference = 25;

    public void Update()
    {
        Slosh();

        liquidMesh.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.Self);
    }

    private void Slosh()
    {
        Quaternion inverseRotation = Quaternion.Inverse(transform.localRotation);

        Vector3 finalRotation = Quaternion.RotateTowards(liquid.transform.localRotation, inverseRotation, sloshSpeed * Time.deltaTime).eulerAngles;

        finalRotation.x = ClampRotationValue(finalRotation.x, difference);
        finalRotation.y = ClampRotationValue(finalRotation.y, difference);

        liquid.transform.localEulerAngles = finalRotation;
    }

    private float ClampRotationValue(float value, float difference)
    {
        float returnValue = 0.0f;

        if (value > 180)
            returnValue = Mathf.Clamp(value, 360 - difference, 360);
        else
            returnValue = Mathf.Clamp(value, 0, difference);

        return returnValue;
    }
}
