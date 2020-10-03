using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckmoves : MonoBehaviour
{

    public float speed = 10.0f;
    public Rigidbody2D duckrb;
    private Vector2 screenBounds;
    public Transform duckcoordinates;


    // Start is called before the first frame update
    void Start()
    {

        duckrb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if ((duckcoordinates.position.x + 5) < ((screenBounds.x - 5)))
        {
            Destroy(this.gameObject);
            
        }
    }


    public void die()
    {

        Destroy(this.gameObject);
        Scoring.score = Scoring.score + 5;
    }
}
