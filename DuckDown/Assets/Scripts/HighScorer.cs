using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScorer : MonoBehaviour
{
    int jmprhighscore;
    Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        jmprhighscore = PlayerPrefs.GetInt("BestScore", jmprhighscore);
        HighScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HighScore.text = ""+jmprhighscore+"";
    }
}
