using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PintFill : MonoBehaviour
{

    [SerializeField] private GameObject text;
    
    public void Fill()
    {
        text.SetActive(true);
        Debug.Log("Fill pint");
    }
}
