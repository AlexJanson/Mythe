using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private bool isHolding;

    private float startTime;
    private Vector3 startPosition;
<<<<<<< HEAD
    private bool isBurning = false;
    public string fireplaceTag = "Fireplace";
    
    private ParticleSystem fireParticles;
    public int layerNumber = 13;
=======
    public float distance;
    private bool isBurning = false;

    private ParticleSystem fireParticles;
    public ParticleSystem fireplace;

    private int layerNumber = 11;
    private string fireplaceTag = "Fireplace";
    public GameObject fireplaceObject;
    private BurningState burningState;
>>>>>>> origin/artist

    private void Awake()
    {
        fireParticles = GetComponent<ParticleSystem>();
<<<<<<< HEAD
=======
        burningState = GameObject.Find("Fireplace Area").GetComponent<BurningState>();
>>>>>>> origin/artist
    }

    private void Ignite()
    {
        var em = fireParticles.emission;
        em.enabled = true;
        isBurning = true;
    }

<<<<<<< HEAD
=======
    private void ToggleFireplace(bool value)
    {
        fireplace = fireplaceObject.GetComponent<ParticleSystem>();
        var em = fireplace.emission;
        em.enabled = value;
        burningState.canCook = value;
    }

>>>>>>> origin/artist
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
<<<<<<< HEAD
        if (isBurning)
        {
            if (other.gameObject.tag == fireplaceTag)
            {
                var em = other.GetComponent<ParticleSystem>().emission;
                em.enabled = true;
=======
        if (other.gameObject.tag == fireplaceTag)
        {
            if (isBurning == true)
            {
                ToggleFireplace(true);
                
>>>>>>> origin/artist
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
