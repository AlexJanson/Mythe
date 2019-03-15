using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soup : MonoBehaviour
{
    private List<Ingredient.NameofIngredient> ingredients;
    private List<Color32> ingredientColors;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ingredient")
        {
            Ingredient objectToCheck = other.gameObject.GetComponent<Ingredient>();

            ingredients.Add(objectToCheck.objectType);          // list of all the ingredients in the soup 
            ingredientColors.Add(objectToCheck.objectColor);    // list with all color values
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "")
        {
            if (ingredients.Count > 0)
            {
                ingredients.Remove(other.gameObject.GetComponent<Ingredient>().objectType);
            }
        }
    }

    private void EmptyCauldron()
    {
        ingredients.Clear();
        ingredientColors.Clear();
    }
}
