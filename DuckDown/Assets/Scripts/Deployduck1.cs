using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deployduck1 : MonoBehaviour
{
    public GameObject duck1;
    public GameObject zombi;
    public float respawnTime1 = 1.0f;
    private Vector2 screenBounds;
    public int wave= 1;
    private float x=5.0f;
    private float y=3.568f;

    // Start is called before the first frame update
    void Start()
    {
        
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(duckwave());
    }

    private void SpawnDuck()
    {

        if (Scoring.score >= 100)
        {
            float randomInt = Random.Range(0f, 100f);
            if (randomInt <= 50)
            {
                GameObject zombduck = Instantiate(zombi) as GameObject;
                zombduck.transform.position = new Vector2(x, y);
            }

            else
            {
                GameObject ducky = Instantiate(duck1) as GameObject;
                ducky.transform.position = new Vector2(x, y);
            }
        }

        else
        {
            GameObject ducky = Instantiate(duck1) as GameObject;
            ducky.transform.position = new Vector2(x, y);
        }
    }

    // Update is called once per frame

    IEnumerator duckwave()
    {
        while (wave == 1)
        {
            yield return new WaitForSeconds(respawnTime1);
            SpawnDuck();

        }
    }

}
