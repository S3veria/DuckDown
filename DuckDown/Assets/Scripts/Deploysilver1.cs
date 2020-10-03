using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploysilver1 : MonoBehaviour
{
    public GameObject silver1;
    public GameObject zombii;
    public float respawnTime1 = 1.0f;
    private Vector2 screenBounds;
    public int wave = 1;
    private float x = 5.0f;
    private float y = 0.68f;
    private int oneinten;

    // Start is called before the first frame update
    void Start()
    {

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(silvermine());
    }

    private void SpawnMine()
    {
        if (Scoring.score >= 250)
        {
            float randomInt = Random.Range(0f, 100f);
            if (randomInt <= 20)
            {
                GameObject zombduck = Instantiate(zombii) as GameObject;
                zombduck.transform.position = new Vector2(x, y);
            }

            else
            {
                GameObject ducky = Instantiate(silver1) as GameObject;
                ducky.transform.position = new Vector2(x, y);
            }
        }
        else
        {
            GameObject ducky = Instantiate(silver1) as GameObject;
            ducky.transform.position = new Vector2(x, y);
        }
    }

    // Update is called once per frame

    IEnumerator silvermine()
    {
        while (wave == 1)
        {
            float randomInt = Random.Range(0f, 200f);
            yield return new WaitForSeconds(respawnTime1);

            if (randomInt <= 25)
            {
                SpawnMine();
            }

        }

        
    }

}