using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LogicScript : MonoBehaviour
{
  public int Score;
  public Text scoreText;
  public GameObject gameOverS;

[ContextMenu("increase count")]
  
  public void addScore(int scoreToAdd){

    Score = Score + scoreToAdd;
    scoreText.text = Score.ToString();
  }
  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

   public void GameOver()
   {
      gameOverS.SetActive(true);
   }

}
