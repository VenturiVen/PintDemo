using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RandDialogue
{
    [SerializeField] public string[] line;

    public string[] Line => line;
}

[System.Serializable]
public class Conversation
{
    [SerializeField] public string conversationName;
    [SerializeField] public string[] line;

    public string ConversationName => conversationName;
    public string[] Line => line;
}

[CreateAssetMenu(fileName = "DialogueScriptableObject", menuName = "ScriptableObjects/Dialogue")]
public class DialogueScriptableObject : ScriptableObject
{
    [Header("Everyday Dialogue")]
    [SerializeField] private List<RandDialogue> greetings;
    [SerializeField] private List<RandDialogue> thoughts;

    [Header("Event Dialogue")]
    [SerializeField] private List<Conversation> events;

    [Header("Conversation Dialogue")]
    [SerializeField] private List<Conversation> conversations;
}
