using UnityEngine;

public class NotitieColor : MonoBehaviour
{

    void Start()
    {

        bool[] randomBools = new bool[]
        {

            ColorManager.GetRndmBool(), ColorManager.GetRndmBool(), ColorManager.GetRndmBool()

        };

        //ColorManager.SetFullColorRGB(this.gameObject, randomBools);

        ColorManager.SetColorRGBA(this.gameObject, (byte)Random.Range(1, 255), (byte)Random.Range(1, 255), (byte)Random.Range(1,255), 255);

    }

}
