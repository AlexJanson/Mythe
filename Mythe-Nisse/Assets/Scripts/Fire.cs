using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private bool isHolding;
    public bool IsHolding { get; set; }

    private float startTime;
    private Vector3 startPosition;

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
        if (other.gameObject.layer == 11)
        {
            startTime = Time.time;
            startPosition = transform.position;
        }

        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == 11)
        {
            float endTime = Time.time;
            Vector3 endPosition = transform.position;

            

        }
        
    }

}
