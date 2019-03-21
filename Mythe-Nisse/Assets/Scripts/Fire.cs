using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private bool isHolding;

    private float startTime;
    private Vector3 startPosition;
    public float distance;

    private ParticleSystem fireParticles;

    private void Awake()
    {
        fireParticles = GetComponent<ParticleSystem>();
    }

    private void Ignite()
    {
        var em = fireParticles.emission;
        em.enabled = true;
    }

    private void Extinguish()
    {
        var em = fireParticles.emission;
        em.enabled = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (isHolding)
        {
            if (other.gameObject.layer == 11)
            {
                startTime = Time.time;
                startPosition = transform.position;
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
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == 11)
        {
            float endTime = Time.time;
            Vector3 endPosition = transform.position;
            Debug.Log(Vector3.Distance(endPosition, startPosition));

            if (endTime - startTime < distance && endTime - startTime > Vector3.Distance(endPosition, startPosition));
            {
                //Debug.Log("succes!");
            }
        }
        
    }

}
