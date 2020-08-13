using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GasFireExtinguisherActivate : MonoBehaviour
{
     ParticleSystem.Particle particle = new ParticleSystem.Particle();
    float tiempoFinal = 2;
    float tiempoInicial = 0;

    ParticleSystem particulas;
 
    void Start()
    {
        particulas = GetComponentInChildren<ParticleSystem>();
       var emission = particulas.emission;
        emission.enabled = false;
    }

    void Update()
    {     
        Speed();
    }

    public void Speed() //Acelera
    {
        var emission = particulas.emission;
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {    
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
