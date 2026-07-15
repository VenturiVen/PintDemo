using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTest : MonoBehaviour
{

    [SerializeField] public ParticleSystem particles;

    private void OnMouseDown()
    {
        particles.Play();
    }
}
