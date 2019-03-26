using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : Ingredient
{
    public Carrot()
    {
        objectColor = new Color32(255, 165, 0, 255);  // orange color
        objectType = NameofIngredient.carrot;       // its a carrot
    }
}