using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BarLogic : MonoBehaviour
{
    [SerializeField] private GameObject CustomerUI;
    private Dialogue dialogue;

    private UILogic ui;

    private void Start()
    {
            ui = GetComponent<UILogic>();
            dialogue = CustomerUI.transform.Find("DialogueBox").GetComponent<Dialogue>();
            DisableCustomerUI();
    }

    public void CustomerClick(CustomerScriptableObject customerScript, DialogueScriptableObject dialogueScript)
    {
        ActivateCustomerUI();
        dialogue.StartDialogue(customerScript, dialogueScript);
    }

    private void ActivateCustomerUI()
    {
        if (CustomerUI.activeSelf)
        {
            Debug.Log("Customer UI already active.");
            return;
        } else 
        {
            ui.ToggleGameObject(CustomerUI);
            ui.ToggleNavButtons();
            ui.ToggleNavBar();
        }
    }

    public void DisableCustomerUI()
    {
        if (!(CustomerUI.activeSelf))
        {
            Debug.Log("Customer UI already inactive.");
            return;
        }
        else
        {
            ui.ToggleGameObject(CustomerUI);
            ui.ToggleNavButtons();
            ui.ToggleNavBar();
        }
    }


}
