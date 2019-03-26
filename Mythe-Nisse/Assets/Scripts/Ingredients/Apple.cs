using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Ingredient
{
    public Apple()
    {
        objectColor = new Color32(255, 0, 0, 255);  // red color
        objectType = NameofIngredient.apple;       // its an apple
    }
}
