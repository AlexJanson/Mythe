using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutIngredient : MonoBehaviour
{
    public GameObject ingredientSmall;
    [Range(1,10)]
    public int amountToSpawn = 3;

    [Range(1,10)]
    public float maxVelocity = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Knife") {
            for (int i = 0; i < amountToSpawn; i++) {
                Destroy(gameObject);
                GameObject temp = Instantiate(ingredientSmall, transform.position, Quaternion.identity);
                Color parentColor = GetComponent<Ingredient>().objectColor;
                var parentType = GetComponent<Ingredient>().objectType;
                temp.GetComponent<Renderer>().material.color = parentColor;
                temp.GetComponent<Ingredient>().objectColor = parentColor;
                temp.GetComponent<Ingredient>().objectType = parentType;
                temp.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-maxVelocity, maxVelocity), Random.Range(0f, maxVelocity), Random.Range(-maxVelocity, maxVelocity));
            }
        }
    }
}
