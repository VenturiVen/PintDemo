using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CustomerScriptableObject", menuName = "ScriptableObjects/Customers")]
public class CustomerScriptableObject : ScriptableObject
{
    [Header("Character Info")]
    [SerializeField] private int id = 0;
    [SerializeField] private new string name = "NameHere";
    [SerializeField] private string drinkPreference = "";

    [Header("Character Stats")]
    [SerializeField] private string state = "";
    [SerializeField] private string mood = "";
    [SerializeField] private int friendshipLvl = 0;
    [SerializeField] private float textSpeed = 0.1f;

    [Header("Character Assets")]
    [SerializeField] private Image defaultSprite;
    [SerializeField] private DialogueScriptableObject dialogue;

    int GetID()
    {
        return id;
    }

    string GetName()
    {
        return name;
    }

    string GetDrinkPreference()
    {
        return drinkPreference;
    }

    string GetState()
    {
        return state;
    }

    void SetState(string newState)
    {
        state = newState;
    }

    string GetMood()
    {
        return mood;
    }

    void SetMood(string newMood)
    {
        mood = newMood;
    }

    int GetFriendShipLevel()
    {
        return friendshipLvl;
    }

    void IncreaseFriendship(int points)
    {
        friendshipLvl += points;
    }

    void DecreaseFriendship(int points)
    {
        friendshipLvl -= points;
    }

    float GetTextSpeed()
    {
        return textSpeed;
    }

    void SetTextSpeed(float newTextSpeed)
    {
        textSpeed = newTextSpeed;
    }

    Image GetDefaultSprite()
    {
        return defaultSprite;
    }

    DialogueScriptableObject GetDialogue()
    {
        return dialogue;
    }
}
