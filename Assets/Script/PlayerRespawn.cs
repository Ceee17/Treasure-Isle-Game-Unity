using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float fallThreshold = -10f; // Set this to the Y position where you consider the player has fallen
    public Transform respawnPoint; // Set this to the desired respawn point

    void Update()
    {
        // Check if the player has fallen below the threshold
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Reset the player's position to the respawn point
        transform.position = respawnPoint.position;
    }
}
