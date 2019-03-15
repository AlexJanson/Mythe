using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IngredientSpawns : Generator
{

    private void Start()
    {

        Vector3[] IngredientPositions = new[] {
            new Vector3(1.5f, 1f, 2f),
            new Vector3(1.9f, 1f, 2f),
            new Vector3(2.3f, 1f, 2f),
            new Vector3(2.3f, 1f, 2.6f),
            new Vector3(1.9f, 1f, 2.6f),
            new Vector3(1.5f, 1f, 2.6f),
        };


        IngredientPositions = ShuffleArray(IngredientPositions);


        for (int i = 0; i < 3; i++)
        {

            var ingredientPrefab = Resources.Load("Ingredients/Ingredient" + i);

            Instantiate(ingredientPrefab,IngredientPositions[i],Quaternion.identity);

            print(IngredientPositions[i]);

        }
   
    }

}
