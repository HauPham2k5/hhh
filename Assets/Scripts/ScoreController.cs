using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public static ScoreController instance;
    public static ScoreController Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<ScoreController>();
            }
            return instance;
        }
    }
   private int score = 0;
    public void IncreaseScore(int value)
    {
        score += value;
       scoreText.text = "Score: " + score.ToString();
    }
   
}
