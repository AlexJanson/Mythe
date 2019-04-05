using UnityEngine;

public class Pan : MonoBehaviour
{

    [SerializeField]
    private GameObject TaskListSoupColor;

    public void CheckColor()
    {

            ColorManager.CheckColorMatch(GameObject.Find("Water"), TaskListSoupColor);

    }

}
