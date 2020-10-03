using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class whynowork : MonoBehaviour
{
    // Start is called before the first frame update
    public void resumegame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        
    }


    public void gohome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Scoring.score = 0;
    }
}

