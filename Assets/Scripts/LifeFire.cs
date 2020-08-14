using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class LifeFire : MonoBehaviour
{
    private bool extinguishedFire;
    public bool ExtinguishedFire { get => extinguishedFire; }

    void OnParticleTrigger()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        // particles
        List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        // get
        int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        var emmision = ps.emission;

        // iterate
        for (int i = 0; i < numEnter; i++)
        {
            emmision.rateOverTimeMultiplier -= 30 * Time.fixedDeltaTime;
            if (emmision.rateOverTimeMultiplier <= 0)
                extinguishedFire = true;
        }
        // set
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
    }
}

