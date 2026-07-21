using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taps_Interaction : MonoBehaviour
{
    // uses PlayerInputManager to activate taps from number keys 1 to 0 (10 taps)

    // might look into switching to holding down they key rather than clicking
    // -> would require changing the PlayerInputManager
    // -> would require changing the ParticleSystem in the taps
    // -> would require changing to Start (click) and Stop (release) tap rather than just start

    [SerializeField] private Transform tapsContainer;
    private Transform[] taps;

    private void Start()
    {
        PlayerInputManager.Instance.OnNumberKeyPressed += HandleNumKey;
    }

    private void Awake()
    {
        taps = new Transform[tapsContainer.childCount];

        for (int i = 0; i < tapsContainer.childCount; i++)
        {
            taps[i] = tapsContainer.GetChild(i);
        }
    }

    private void HandleNumKey(int num)
    {
        int index = num;

        if (index != 0)
        {
            index = num - 1;
        }
        else
        {
            index = 9;
        }

        if (index >= taps.Length)
        {
            Debug.Log("Tap " + num + " does not exist.");
            return;
        }

        if (taps[index] != null)
        {
            StartTap(index);
        }
        else
        {
            Debug.Log("Tap GameObject " + num + " does not exist.");
            return;
        }
    }

    private void StartTap(int index)
    {
        if (taps[index] != null)
        {
            Debug.Log("Starting tap: " + (index + 1));

            ParticleSystem particle = taps[index].GetComponentInChildren<ParticleSystem>();

            if (particle != null)
            {
                particle.Play();
            }
        }
    }

}
