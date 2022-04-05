using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerControls.Player.Movement.ReadValue<Vector2>();
    }

    public bool LightAtk()
    {
        return playerControls.Player.Light.triggered;
    }
    public bool HeavyAtk()
    {
        return playerControls.Player.HeavyTop.triggered;
    }
    public bool KickAtk()
    {
        return playerControls.Player.KickBottom.triggered;
    }
    public bool SpecialAtk()
    {
        return playerControls.Player.Light.triggered;
    }
}
