using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;

    public void Setup()
    {
        // Disable the pointsText
        pointsText.gameObject.SetActive(false);
        // Set the entire GameOverScreen gameObject to active
        gameObject.SetActive(true);
    }


    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }
}
