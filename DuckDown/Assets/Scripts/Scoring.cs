using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoring : MonoBehaviour
{


    public static int score = 0;
 
    Text cosaloca;
    int jmprhighscore;
       
    // Start is called before the first frame update
    void Start()
    {
        cosaloca = GetComponent<Text>();
        jmprhighscore = PlayerPrefs.GetInt("BestScore", jmprhighscore);

    }

    // Update is called once per frame
    void Update()
    {
        cosaloca.text = ""+score+"";

    }
}
