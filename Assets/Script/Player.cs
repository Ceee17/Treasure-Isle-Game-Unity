using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
  //  public GameOverScreen gameOverScreen;

//    private void Start()
  //  {
  //      gameOverScreen = FindObjectOfType<GameOverScreen>();
   // }
 
 //   private void OnTriggerEnter(Collider other)
  //  {
 //       // Check if the collided object is an enemy
 //       if (other.CompareTag("Enemy"))
 //       {
 //           // Implement player death logic
 //           Die();
 //           GameFinished();
 //       }
 //   }

    public void Die()
    {
        // Implement player death logic (e.g., play death animation, disable controls, etc.)
        // For simplicity, we destroy the player GameObject in this example
        Destroy(gameObject);
  //      GameFinished();
 
    }

  //  private void GameFinished()
  //  {
        // Get updated score
//        int score = FindObjectOfType<PengaturGame>().CalculateScore();

        // Show game over screen
 //       gameOverScreen.Setup(score);
 //   }

}
