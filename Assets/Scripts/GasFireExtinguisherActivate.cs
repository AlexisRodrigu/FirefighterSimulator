using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GasFireExtinguisherActivate : MonoBehaviour
{
    private ParticleSystem ps;
    private Collider collider;

    private void Awake()
    {
        ps = GetComponentInChildren<ParticleSystem>();
        collider = GetComponent<Collider>();
    }
    void Start()
    {
        var emission = ps.emission;
        emission.enabled = false;
    }

    void Update()
    {
        Speed();
    }

    public void Speed() //Acelera
    {
        var emission = ps.emission;
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            collider.enabled = true;
            emission.enabled = true;
            emission.type = ParticleSystemEmissionType.Time;

            emission.SetBursts(
                new ParticleSystem.Burst[]{
                new ParticleSystem.Burst(2.0f, 100),
                new ParticleSystem.Burst(4.0f, 100)
                });
        }
        else
        {
            collider.enabled = false;
            emission.enabled = false;
            emission.type = ParticleSystemEmissionType.Time;

            emission.SetBursts(
                new ParticleSystem.Burst[]{
                new ParticleSystem.Burst(2.0f, 100),
                new ParticleSystem.Burst(4.0f, 100)
                });
        }
    }
}
