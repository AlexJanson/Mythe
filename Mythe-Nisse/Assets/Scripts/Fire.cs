using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private bool isHolding;
    public bool IsHolding { get; set; }

    private float timer;
    private readonly float maxTimer = 1;

    private Rigidbody rb;
    private ParticleSystem fireParticles;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
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

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag != "Player")
        {
            if (isHolding)
            {

            }
            Extinguish();
        }
        
    }

}
