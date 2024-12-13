using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOverworld : MonoBehaviour
{
    

    [Header("Movement Settings")]
    public float moveSpeed = 5f; // Player's movement speed

    [Header("Components")]
    public Animator animator; // Reference to the Animator component
    public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    private Vector3 movement; // Stores movement input
    private string lastDirection = "Side"; // Tracks the last direction for idle animation
    private bool isFlipped = false; // Tracks the current flip state

    public bool isMoving;
    void Update()
    {
        // Get movement input (X and Z for 3D)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        if(Mathf.Abs(movement.x) > 0 || Mathf.Abs(movement.z) > 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        // Normalize movement vector to prevent faster diagonal movement
        movement = movement.normalized;

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        // Update animations and sprite direction
        UpdateAnimations();
    }

    void UpdateAnimations()
    {
        if (movement != Vector3.zero)
        {
            // Movement detected
            if (Mathf.Abs(movement.x) > 0 && Mathf.Abs(movement.z) > 0)
            {
                // Diagonal movement (uses WalkSide animation)
                animator.Play("John_WalkSide");
                lastDirection = "Side";

                // Flip based on horizontal input
                UpdateSpriteFlip(movement.x);
            }
            else if (Mathf.Abs(movement.x) > 0)
            {
                // Horizontal movement (Side animation)
                animator.Play("John_WalkSide");
                lastDirection = "Side";

                // Flip based on horizontal input
                UpdateSpriteFlip(movement.x);
            }
            else if (movement.z > 0)
            {
                // Forward movement (Up animation)
                animator.Play("John_WalkUp");
                lastDirection = "Up";
            }
            else if (movement.z < 0)
            {
                // Backward movement (Down animation)
                animator.Play("John_WalkDown");
                lastDirection = "Down";
            }
        }
        else
        {
            // No movement, play idle animation based on last direction
            switch (lastDirection)
            {
                case "Side":
                    animator.Play("John_IdleSide");
                    break;
                case "Up":
                    animator.Play("John_IdleUp");
                    break;
                case "Down":
                    animator.Play("John_IdleDown");
                    break;
            }
        }
    }

    void UpdateSpriteFlip(float horizontalInput)
    {
        if (horizontalInput > 0 && isFlipped)
        {
            // Moving right, reset flip
            spriteRenderer.flipX = false;
            isFlipped = false;
        }
        else if (horizontalInput < 0 && !isFlipped)
        {
            // Moving left, apply flip
            spriteRenderer.flipX = true;
            isFlipped = true;
        }
    }
}
