using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager Instance { get; private set; }

    public event System.Action<int> OnNumberKeyPressed;

    private PlayerInputActions input;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        input = new PlayerInputActions();
    }

    private void OnEnable()
    {
        input.Controller.Enable();
        input.Controller.NumberKeys.performed += OnNumKey;
    }

    private void OnDisable()
    {
        input.Controller.NumberKeys.performed -= OnNumKey;
        input.Controller.Disable();
    }

    private void OnNumKey(InputAction.CallbackContext context)
    {
        if (int.TryParse(context.control.displayName, out int num))
        {
            Debug.Log("Number key pressed: " + num);
            OnNumberKeyPressed?.Invoke(num);
        }
    }
}
