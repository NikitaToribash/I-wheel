using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;

    public Text scoreText; 

    void Start()
    {
     
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.Space))
{
            score++;
            
        }

    }

}
