using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiScale : MonoBehaviour
{

    private float speed;
    public bool triggerdScale;
    public GameObject player;

    private void Start()
    {
        speed = 2f;
        triggerdScale = false;
    }

    void Update()
    {
        if(triggerdScale)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), speed * Time.deltaTime);
        }



    }
}
