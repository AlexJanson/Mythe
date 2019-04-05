using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIngredients : MonoBehaviour
{
    public GameObject prefab;
    public float timesScale;
    public Vector3 spawnOffset, rotationOffset;

    private bool hasIngredient;

    private void Start()
    {
        SpawnIngredient();
    }

    private void Update()
    {
        if (!hasIngredient) SpawnIngredient();
    }

    private void SpawnIngredient()
    {
        GameObject temp = Instantiate(prefab, transform.position + spawnOffset, transform.rotation * Quaternion.Euler(rotationOffset.x, rotationOffset.y, rotationOffset.z));
        temp.transform.parent = null;
        temp.transform.localScale = new Vector3(temp.transform.localScale.x * timesScale, temp.transform.localScale.y * timesScale, temp.transform.localScale.z * timesScale);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "ingredient") {
            hasIngredient = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "ingredient") {
            hasIngredient = true;
        } else {
            hasIngredient = false;
        }
    }
}
