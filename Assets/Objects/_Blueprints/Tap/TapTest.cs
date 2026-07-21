using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTest : MonoBehaviour
{

    [SerializeField] public ParticleSystem particles;

    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        var pint = other.GetComponent<PintFill>();

        if (pint != null)
        {
            pint.Fill();
        }
    }
}
