using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    private BarLogic bar;

    [SerializeField] public CustomerScriptableObject customerScript;
    [SerializeField] public DialogueScriptableObject dialogueScript;

    void Start()
    {
        try
        {
            bar = GameObject.FindGameObjectWithTag("SceneLogic").GetComponent<BarLogic>();
        } catch {
            Debug.Log("Could not find BarLogic");
        }

        if (customerScript == null)
        {
            Debug.Log("Customer Script is null");
        }

        if (dialogueScript == null)
        {
            Debug.Log("DialogeScript is null");
        }
    }

    // on mouse click
    private void OnMouseDown()
    {
        bar.CustomerClick(customerScript, dialogueScript);
    }


}
