using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private bool crouched;
    private InputManager inputManager;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        inputManager = GetComponent<InputManager>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movement = inputManager.GetPlayerMovement(); //Get the player input value from the input manager
        Vector3 move = new Vector3(movement.x, 0, 0); // Player Movement on X axis only
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            //gameObject.transform.forward = move;
        }

        
        if (movement.y >= 0.7f && groundedPlayer) //Jump if player presses a positive y value
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }


        /*if (crouched && groundedPlayer) //Crouch if player presses a negative y value
        {
            transform.localScale += new Vector3(transform.localScale.x, -0.5f, transform.localScale.z);
            controller.height = 1.6f;
        }
        else if (!crouched)
        {
            transform.localScale += new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
            controller.height = 2.0f;
        }*/
        
        if(movement.y <= -0.7f)
        {
            crouched = true;
        }

        if(movement.y >= -0.7f)
        {
            crouched = false;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
