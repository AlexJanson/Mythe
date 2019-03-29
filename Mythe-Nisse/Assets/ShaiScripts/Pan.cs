using UnityEngine;

public class Pan : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag.Contains("Tafel"))
        {

            ColorManager.CheckColorMatch(GameObject.Find("Soup"), GameObject.Find("Blaadje"));

        }

    }

}
