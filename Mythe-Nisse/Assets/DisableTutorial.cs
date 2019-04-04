using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTutorial : MonoBehaviour
{ 
    public float delay;

    private void Start()
    {
        StartCoroutine(DisableCanvas());
    }

    IEnumerator DisableCanvas()
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("Disabling the canvas!");
        gameObject.SetActive(false);
        yield return null;
    }
}
