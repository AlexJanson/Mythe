using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soup : MonoBehaviour
{
    private List<Ingredient.NameofIngredient> ingredients = new List<Ingredient.NameofIngredient>();
    [SerializeField]
    private List<Color> ingredientColors = new List<Color>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ingredient")
        {
            Ingredient objectToCheck = other.gameObject.GetComponent<Ingredient>();
            Debug.Log(objectToCheck.objectColor);

            ingredients.Add(objectToCheck.objectType);          // list of all the ingredients in the soup 
            ingredientColors.Add(objectToCheck.objectColor);    // list with all color values
            Debug.Log(ingredients);
            Debug.Log(ingredientColors);

            Destroy(other.gameObject);

            Renderer rend = GetComponent<Renderer>();

            //rend.material.shader = Shader.Find("_Tint");
            rend.material.SetColor("_Tint", AverageColor(ingredientColors));
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "")
    //    {
    //        if (ingredients.Count > 0)
    //        {
    //            ingredients.Remove(other.gameObject.GetComponent<Ingredient>().objectType);
    //        }
    //    }
    //}

    private void EmptyCauldron()
    {
        ingredients.Clear();
        ingredientColors.Clear();
    }

    private Color AverageColor(List<Color> colors) {
        Vector3 rgb = Vector3.zero;
        foreach(Color c in colors) {
            rgb += new Vector3(c.r, c.g, c.b);
        }

        Color average = new Color(rgb.x / colors.Count, rgb.y / colors.Count, rgb.z / colors.Count, 0.78f);

        return average;
    }
}
