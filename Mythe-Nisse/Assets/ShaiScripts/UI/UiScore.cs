using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class UiScore
{

    public static void SetText(float r, float g, float b)
    {
            GameObject.Find("UiScore").gameObject.GetComponent<TextMesh>().text = "Color Match" + "\n" +
            "R : " + r + "%" + "\n" +
            "G : " + g + "%" + "\n" + 
            "B : " + b + "%";

            TriggerUisCale();
    }

    public static void TriggerUisCale()
    {
        GameObject.Find("Score").gameObject.GetComponent<UiScale>().triggerdScale = true;
    }
}
