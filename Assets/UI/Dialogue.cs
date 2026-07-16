using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.Assertions.Comparers;
using UnityEditor.UI;

// https://youtu.be/8oTYabhj248?si=XwbgnJzovtB9DUHa

public class Dialogue : MonoBehaviour
{
    private BarLogic bar;
    private TextMeshProUGUI nameText;
    private TextMeshProUGUI dialogueText;
    private GameObject customerUI;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Awake()
    {
            bar = GameObject.FindGameObjectWithTag("SceneLogic").GetComponent<BarLogic>();
            customerUI = GameObject.FindGameObjectWithTag("CustomerUI");
            nameText = customerUI.transform.Find("NameBox").GetChild(0).GetComponent<TextMeshProUGUI>();
            nameText.text = string.Empty;
            dialogueText = customerUI.transform.Find("DialogueBox").GetChild(0).GetComponent<TextMeshProUGUI>();
            dialogueText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
    }

    public void StartDialogue(CustomerScriptableObject customerScript, DialogueScriptableObject dialogueScript)
    {
        nameText.text = string.Empty;
        dialogueText.text = string.Empty;
        nameText.text = customerScript.GetName();
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        } else
        {
            bar.DisableCustomerUI();
        }
    }

}
