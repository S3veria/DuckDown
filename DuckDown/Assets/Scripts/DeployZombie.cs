using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployZombie : MonoBehaviour
{
    public GameObject zombie1;
    float respawnTime1 = 1.5f;
    private Vector2 screenBounds;
    public int wave = 1;
    private float x = -5.0f;
    private float y = 2.18f;
    private int oneinten;

    // Start is called before the first frame update
    void Start()
    {

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(zombs());
    }

    private void SpawnZombie()
    {
        GameObject ducky = Instantiate(zombie1) as GameObject;
        ducky.transform.position = new Vector2(x, y);
    }

    // Update is called once per frame

    IEnumerator zombs()
    {
        while (wave == 1)
        {
            if (Scoring.score >= 50)
            {
                respawnTime1 = 1f;
            }
            yield return new WaitForSeconds(respawnTime1);
            SpawnZombie();


        }


    }

}
