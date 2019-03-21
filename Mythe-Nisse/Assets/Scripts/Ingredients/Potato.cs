using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : Ingredient
{
    public Potato()
    {
        objectColor = new Color32(255, 197, 124, 255);  // gross potato color
        objectType = NameofIngredient.potato;       // its a potato
    }
}