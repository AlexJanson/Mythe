using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{

    [SerializeField]
    private GameObject TaskListSoupColor;
    public GameObject[] objectstoUpdate;

    public Vector3 teleportPoint;
    public Rigidbody rb;


       

    public void CheckColor()
    {

            ColorManager.CheckColorMatch(GameObject.Find("Water"), TaskListSoupColor);

    }

    GameObject[] FindGameObjectsInLayer(int layer)
    {
        var goArray = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        var goList = new System.Collections.Generic.List<GameObject>();
        for (int i = 0; i < goArray.Length; i++)
        {
            if (goArray[i].layer == layer)
            {
                goList.Add(goArray[i]);
            }
        }
        if (goList.Count == 0)
        {
            return null;
        }
        return goList.ToArray();
    }

}
