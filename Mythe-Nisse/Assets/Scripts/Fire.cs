using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private bool isHolding;

    private float startTime;
    private Vector3 startPosition;
    public float distance;
    private bool isBurning = false;

    private ParticleSystem fireParticles;
    public ParticleSystem fireplace;

    private int layerNumber = 11;
    private string fireplaceTag = "Fireplace";

    private void Awake()
    {
        fireParticles = GetComponent<ParticleSystem>();
    }

    private void Ignite()
    {
        var em = fireParticles.emission;
        em.enabled = true;
        isBurning = true;
    }

    private void Extinguish()
    {
        var em = fireParticles.emission;
        em.enabled = false;
        isBurning = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (isHolding)
        {
            if (!isBurning)
            {
                if (other.gameObject.layer == layerNumber)
                {
                    startTime = Time.time;
                    startPosition = transform.position;
                }
            }
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == layerNumber)
        {
            float endTime = Time.time;
            Vector3 endPosition = transform.position;

            if (endTime - startTime < Vector3.Distance(endPosition, startPosition))
            {
                Ignite();
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == fireplaceTag)
        {
            if (isBurning == true)
            {
                var em = fireplace.emission;
                em.enabled = true;
            }
        }
    }

    public void IsHolding()
    {
        isHolding = true;
    }

    public void IsNotHolding()
    {
        isHolding = false;
        Extinguish();
    }

}
