using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyPool
{
    public EnemyData northEnemy;
    public EnemyData westEnemy;
    public EnemyData eastEnemy;
    public EnemyData southEnemy;
}

public class Encounter : MonoBehaviour
{
    public List<EnemyPool> enemyPool;
    private float chance = 0f; // Starting chance
    private float chanceIncreaseRate = 0.05f; // Rate of increase per second
    private float checkInterval = 0.3f; // Check interval in seconds
    private float timeSinceLastCheck = 0f; // Time tracker for interval
    private float cooldownTime = 3f; // Cooldown duration after trigger
    private float timeSinceLastTrigger = 0f; // Time tracker for cooldown
    private bool isOnCooldown = false; // Flag for cooldown status

    private void OnTriggerStay(Collider other)
    {
        // Check if the object triggering the collider has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Try to get the PlayerMovementOverworld script from the triggering object
            PlayerMovementOverworld playerMovement = other.GetComponent<PlayerMovementOverworld>();

            if (playerMovement != null && playerMovement.isMoving)
            {
                if (isOnCooldown)
                {
                    // Update the cooldown timer
                    timeSinceLastTrigger += Time.deltaTime;

                    // Exit cooldown if enough time has passed
                    if (timeSinceLastTrigger >= cooldownTime)
                    {
                        isOnCooldown = false;
                        timeSinceLastTrigger = 0f;
                    }
                    return; // Skip further checks during cooldown
                }

                // Increment the time since the last check
                timeSinceLastCheck += Time.deltaTime;

                // Perform the check only if enough time has passed
                if (timeSinceLastCheck >= checkInterval)
                {
                    // Generate a random number and check based on the current chance
                    if (Random.value <= chance) // Random.value generates a float between 0.0 and 1.0
                    {
                        Debug.Log("Chance triggered while Player is moving! Current chance: " + chance);
                        chance = 0f; // Reset chance after triggering
                        isOnCooldown = true; // Start cooldown
                    }
                    else
                    {
                        // Increase the chance over time
                        chance = Mathf.Clamp01(chance + chanceIncreaseRate);
                    }

                    // Reset the time tracker
                    timeSinceLastCheck = 0f;
                }
            }
        }
    }
}
