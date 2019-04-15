using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIngredients : MonoBehaviour
{
    public GameObject prefab;
    public float timesScale;
    public Vector3 spawnOffset, rotationOffset;

    private bool hasIngredient;

    private List<Collider> colliders = new List<Collider>();

    private void Start()
    {
        SpawnIngredient();
    }

    private void Update()
    {
        if (colliders.Count == 0) hasIngredient = false;
        else hasIngredient = true;
        if (!hasIngredient) SpawnIngredient();
    }

    private void SpawnIngredient()
    {
        GameObject temp = Instantiate(prefab, transform.position + spawnOffset, transform.rotation * Quaternion.Euler(rotationOffset.x, rotationOffset.y, rotationOffset.z));
        temp.transform.parent = null;
        temp.gameObject.tag = "ingredient";
        temp.transform.localScale = new Vector3(temp.transform.localScale.x * timesScale, temp.transform.localScale.y * timesScale, temp.transform.localScale.z * timesScale);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "ingredient" && colliders.Contains(other)) {
            colliders.Remove(other);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "ingredient" && !colliders.Contains(other)) {
            colliders.Add(other);
        }
    }
}
