using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToSnapPoint : MonoBehaviour
{
    private bool keepOnSnap = false;
    private Transform SnapPoint;
    private bool isInSnapRange = false;

    // Update is called once per frame
    void Update()
    {
        if(keepOnSnap)
        {
            transform.position = SnapPoint.position;
            transform.rotation = SnapPoint.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SnapPoint")
        {
            isInSnapRange = true;
            SnapPoint = other.transform.root;
            other.transform.root.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SnapPoint")
        {
            isInSnapRange = false;
            other.transform.root.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        }
    }

    public void doSnap()
    {
        if(isInSnapRange)
        {
            keepOnSnap = true;
            SnapPoint.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
            Debug.Log("begin snap");
            GetComponent<Pan>().CheckColor();
        }
    }

    public void StopSnap()
    {
        keepOnSnap = false;
        SnapPoint.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        Debug.Log("stop snap");
    }
}
