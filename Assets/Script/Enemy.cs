using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameOverScreen gameOverScreen;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.Die();
                GameFinishedForEnemy();
            }
        }
        else if (other.CompareTag("Fire"))
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    private void GameFinishedForEnemy()
    {
        // Implement game finished logic specific to the enemy
        // (e.g., different scoring, behavior, etc.)
  //      int score = FindObjectOfType<PengaturGame>().CalculateScore();
        gameOverScreen.Setup();
    }
}
