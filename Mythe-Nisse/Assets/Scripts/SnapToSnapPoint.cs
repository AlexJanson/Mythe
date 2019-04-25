using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToSnapPoint : MonoBehaviour
{
    private bool keepOnSnap = false;
    private Transform SnapPoint;
    private bool isInSnapRange = false;
<<<<<<< HEAD
    private bool finalSnapInRange = false;

    [SerializeField]
    private GameObject water;
    [SerializeField]
    private GameObject note;
=======
>>>>>>> origin/artist

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
<<<<<<< HEAD
        } else if(other.tag == "FinalPoint")
        {
            finalSnapInRange = true;
            SnapPoint = other.transform.root;
            other.transform.root.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
            
=======
>>>>>>> origin/artist
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SnapPoint")
        {
            isInSnapRange = false;
            other.transform.root.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
<<<<<<< HEAD
        } else if(other.tag == "FinalPoint")
        {
            finalSnapInRange = false;
            other.transform.root.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
=======
>>>>>>> origin/artist
        }
    }

    public void doSnap()
    {
        if(isInSnapRange)
        {
            keepOnSnap = true;
            SnapPoint.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
<<<<<<< HEAD
            ColorManager.CheckColorMatch(water, note);
        } else if (finalSnapInRange)
        {
            keepOnSnap = true;
            SnapPoint.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
=======
            Debug.Log("begin snap");
>>>>>>> origin/artist
        }
    }

    public void StopSnap()
    {
<<<<<<< HEAD
        if (keepOnSnap)
        {
            SnapPoint.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        }
        keepOnSnap = false;
=======
        keepOnSnap = false;
        SnapPoint.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        Debug.Log("stop snap");
>>>>>>> origin/artist
    }
}
