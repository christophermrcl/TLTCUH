using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldCamera : MonoBehaviour
{
    [Header("Target to Follow")]
    public Transform player; // Reference to the player object

    [Header("Camera Settings")]
    public Vector3 offset = new Vector3(0, 5, -10); // Offset from the player

    void LateUpdate()
    {
        if (player == null)
        {
            Debug.LogWarning("Player transform is not assigned!");
            return;
        }

        // Calculate the desired position
        Vector3 desiredPosition = player.position + offset;

        transform.position = desiredPosition;
    }
}
