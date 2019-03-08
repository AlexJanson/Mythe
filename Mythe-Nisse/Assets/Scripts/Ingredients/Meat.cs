using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : Ingredient
{
    public Meat()
    {
        objectColor = new Color32(255, 20, 147, 255);  // meat color
        objectType = NameofIngredient.meat;       // its a pile of meat
    }
}
