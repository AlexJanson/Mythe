using UnityEngine;
using UnityEngine.SceneManagement;

public static class ColorManager 
{

    [SerializeField]
    private readonly static string mainSceneString = "Main3";

    public static void SetColorRGBA(GameObject prefab, byte r, byte g, byte b, byte a)
    {

        prefab.GetComponent<Renderer>().material.color = new Color32(r, g, b, a);

    }


    public static void SetFullColorRGB(GameObject prefab, bool[] rgb)
    {

        int[] colorValues = new int[] 
        {

            0,0,0,1

        };


        for(int i = 0; i < rgb.Length; i++)
        {

            if(rgb[i])
            {
                colorValues[i] = 1;
            }
            else
            {
                colorValues[i] = 0;
            }

            prefab.GetComponent<Renderer>().material.color = new Color(colorValues[0], colorValues[1], colorValues[2], colorValues[3]);

        }

    }


    public static void MixColor(GameObject Object, GameObject other)
    {

        var otherColor = other.GetComponent<Renderer>().material.color;
        var ObjectColor = Object.GetComponent<Renderer>().material.color;

        var ObjectRender = Object.GetComponent<Renderer>();

        float newR = ((otherColor.r) + (ObjectColor.r)) /2;
        float newG = ((otherColor.g) + (ObjectColor.g)) /2;
        float newB = ((otherColor.b) + (ObjectColor.b)) /2;

        ObjectRender.material.color = new Color(newR, newG, newB, 1f);

    }


    public static void CheckColorMatch(GameObject Object1, GameObject Object2)
    {

        float percentageOffset = 50;

        float percentageR;
        float percentageG;
        float percentageB;

        var obj1 = Object1.GetComponent<Renderer>().material.GetColor("_Tint");
        var obj2 = Object2.GetComponent<Renderer>().material.GetColor("_Color");

        Vector3 obj1RGB = new Vector3(obj1.r, obj1.g, obj1.b);
        Vector3 obj2RGB = new Vector3(obj2.r, obj2.g, obj2.b);
    

        if(obj1.r > obj2.r)
        {
            percentageR = (100/obj1.r) * obj2.r;
        }else
        {
            percentageR = (100 / obj2.r) * obj1.r;
        }

        if (obj1.g > obj2.g)
        {
            percentageG = (100 / obj1.g) * obj2.g;
        }
        else
        {
            percentageG = (100 / obj2.g) * obj1.g;
        }

        if (obj1.b > obj2.b)
        {
            percentageB = (100 / obj1.b) * obj2.b;
        }
        else
        {
            percentageB = (100 / obj2.b) * obj1.b;
        }

        if ((percentageR > percentageOffset) && (percentageG > percentageOffset) && (percentageB > percentageOffset))
        {
            //Debug.Log("Match " + "R: " + percentageR + "G: " + percentageG + "B: " + percentageB);
            SceneManager.LoadScene(mainSceneString);
        }

            UiScore.SetText(percentageR, percentageG, percentageB);


    }


    public static bool GetRndmBool()
    {

        return (Random.value > 0.5f);

    }

}
