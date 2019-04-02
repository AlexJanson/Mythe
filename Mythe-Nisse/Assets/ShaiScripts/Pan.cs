using UnityEngine;

public class Pan : MonoBehaviour
{

    public void CheckColor()
    {

            ColorManager.CheckColorMatch(GameObject.Find("Water"), GameObject.Find("SoupColor"));

    }

}
