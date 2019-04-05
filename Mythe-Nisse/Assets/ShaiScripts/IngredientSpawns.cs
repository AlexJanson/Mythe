using System.Collections.Generic;
using UnityEngine;


public class IngredientSpawns : MonoBehaviour 
{

    List<Vector3> IngredientPos = new List<Vector3>(); 

    private void Start()
    {

        GameObject[] ingredientList;
        ingredientList = GameObject.FindGameObjectsWithTag("IngredientSpawn");

        for (int i = 0; i < ingredientList.Length; i++)
        {
            IngredientPos.Add(ingredientList[i].transform.position);
        }


        var ingredientSpawmsShuffled = Generator.ShuffleArray(IngredientPos.ToArray());


        for (int i = 0; i < 5; i++)
        {

            var ingredientPrefab = Resources.Load("Ingredients/Ingredient" + i);

            Instantiate(ingredientPrefab,ingredientSpawmsShuffled[i],Quaternion.identity);

        }

        
   
    }

}
