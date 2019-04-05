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

    [SerializeField]
    private LayerMask layerNumber = 11;
    private string fireplaceTag = "Fireplace";
    public GameObject fireplaceObject;
    private BurningState burningState;

    private void Awake()
    {
        fireParticles = GetComponent<ParticleSystem>();
        burningState = GameObject.Find("Fireplace Area").GetComponent<BurningState>();
    }

    private void Ignite()
    {
        var em = fireParticles.emission;
        em.enabled = true;
        isBurning = true;
    }

    private void ToggleFireplace(bool value)
    {
        fireplace = fireplaceObject.GetComponent<ParticleSystem>();
        var em = fireplace.emission;
        em.enabled = value;
        burningState.canCook = value;
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
                ToggleFireplace(true);
                
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
