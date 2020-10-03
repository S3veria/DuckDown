using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rb;
    private Vector2 screenBounds;
    public Transform bulletcoordinates;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        rb.velocity = transform.up*speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        duckmove pleasework = hitInfo.GetComponent<duckmove>();
        duckmoves pleasesilver = hitInfo.GetComponent<duckmoves>();
        duckmovez pleasezombie = hitInfo.GetComponent<duckmovez>();
        if (pleasework!=null)
        {
            pleasework.die();
            Destroy(this.gameObject);
        }


        if (pleasesilver != null)
        {
            pleasesilver.die();
            Destroy(this.gameObject);
        }


        if (pleasezombie != null)
        {
            pleasezombie.die();
            Destroy(this.gameObject);
        }
        


    }

    void Update()
    {
        if ((bulletcoordinates.position.y-3 ) > ((screenBounds.y )))
        {
            Destroy(this.gameObject);
        }
    }
}
