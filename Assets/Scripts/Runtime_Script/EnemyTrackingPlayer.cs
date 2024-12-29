using UnityEngine;

public class EnemyTrackingPlayer : MonoBehaviour
{
    Transform player; // Current player being tracked
    public float maxTrackingDistance = 20f; // Maximum distance to track players
    public float rotationSpeed = 180f; // Degrees per second for smooth rotation

    void UpdateNearestPlayer()
    {
        // Find all players tagged "Player"
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        float closestDistance = Mathf.Infinity;
        Transform closestPlayer = null;

        // Find the closest player within maxTrackingDistance
        foreach (GameObject go in players)
        {
            if (go == null) continue;

            float distance = Vector3.Distance(transform.position, go.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestPlayer = go.transform;
            }
        }

        // Update the tracked player
        if (closestPlayer != null && closestDistance <= maxTrackingDistance)
        {
            player = closestPlayer;
        }
        else if (player != null && Vector3.Distance(transform.position, player.position) > maxTrackingDistance)
        {
            player = null; // Stop tracking if the last known player is too far
        }
    }

    void Update()
    {
        // Update the nearest player
        UpdateNearestPlayer();

        if (player == null)
        {
            return; // Skip tracking if no player is found
        }

        // Calculate the direction to the player
        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        // Calculate the target rotation
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion targetRotation = Quaternion.Euler(0, 0, zAngle);

        // Smoothly rotate towards the target
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed *  Time.deltaTime);
    }
}
