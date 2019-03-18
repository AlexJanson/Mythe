using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour
{
    public Transform potBottom;
    public float maxY = 0.0f;

    public void Start()
    {
        Move();
    }

    public void Update()
    {
        
        Move();
    }

    private void Move()
    {
        Vector3 pos = transform.localPosition;
        pos.y = maxY;
        transform.localPosition = pos;
    }
}
