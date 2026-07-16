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

    public int GetID()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDrinkPreference()
    {
        return drinkPreference;
    }

    public string GetState()
    {
        return state;
    }

    public void SetState(string newState)
    {
        state = newState;
    }

    public string GetMood()
    {
        return mood;
    }

    public void SetMood(string newMood)
    {
        mood = newMood;
    }

    public int GetFriendShipLevel()
    {
        return friendshipLvl;
    }

    public void IncreaseFriendship(int points)
    {
        friendshipLvl += points;
    }

    public void DecreaseFriendship(int points)
    {
        friendshipLvl -= points;
    }

    public float GetTextSpeed()
    {
        return textSpeed;
    }

    public void SetTextSpeed(float newTextSpeed)
    {
        textSpeed = newTextSpeed;
    }

    public Image GetDefaultSprite()
    {
        return defaultSprite;
    }
}
