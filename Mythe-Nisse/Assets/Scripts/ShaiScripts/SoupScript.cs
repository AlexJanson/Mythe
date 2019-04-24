using UnityEngine;

public class SoupScript : MonoBehaviour
{

    private void Start()
    {

        ColorManager.SetColorRGBA(this.gameObject,255,255,255,255);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Contains("Ingredient"))
        {

            ColorManager.MixColor(this.gameObject,other.gameObject);

        }


        else if (other.gameObject.tag.Contains("Water"))
        {

            ColorManager.SetColorRGBA(this.gameObject,255,255,255,1);

        }

    }

}
