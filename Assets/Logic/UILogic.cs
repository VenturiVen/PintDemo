using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILogic : MonoBehaviour
{

    [SerializeField] private GameObject HUD;
    private GameObject NavButtons;
    private GameObject NavBar;

    void Start()
    {
        try
        {
            NavButtons = HUD.transform.GetChild(4).gameObject;
            NavBar = HUD.transform.GetChild(0).gameObject;
        } catch
        {
            Debug.Log("Unable to find GameObject in UI");
        }
    }

    public void ToggleGameObject(GameObject obj)
    {
        if (obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }

    public void ToggleHud()
    {
        if (HUD != null)
        {
            ToggleGameObject(HUD);
        }
    }

    public void ToggleNavButtons()
    {
        ToggleGameObject(NavButtons);
    }

    public void ToggleNavBar()
    {
        ToggleGameObject(NavBar);
    }
}
