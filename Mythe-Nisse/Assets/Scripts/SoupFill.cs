using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupFill : MonoBehaviour
{
    Renderer rend;
    [Range(0f, 1f)]
    public float fillAmount = 0.50f;
    public float fillAmountPercent;
    public Color stdColor;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    
    void Update()
    {
        fillAmountPercent = Mathf.Lerp(0.449f, 0.551f, fillAmount);
        rend.material.SetFloat("_FillAmount", fillAmountPercent);
    }

    public void Empty()
    {
        fillAmount = 1f;
    }

    public void Fill()
    {
        fillAmount = 0f;
    }
}